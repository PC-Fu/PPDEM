/*
File         : ISNCommentAPI.js 1.0.0.0 - ISN Commenting API Tool
Description  : This tool bring commenting to any web page (type=text/html) delivery
Developed By : Kevin M Pirkl
Release Date : 03-19-2007
             :
Notes        : ISNCommentAPI.js supports the ability to embed commenting 
             :  capabilities into any web page.  There are a few things to be aware of.
             :
             : Comments are stored in the database using root referring domain name + CBCommentPath 
             : or if that is left alone then referring domain name + referring URL 
             : CBCommentPath allows you to group comments however you want (more below)
             :  
             :  REQUIREMENTS 
             :  File - jquery-latest.js from jQuery.com - 
             :  File - json.js (slightly modified version)
             :  File - isn.js referenced at http://cache-www.intel.com/plt/cd/software/shared/eng/dhtml/isn.js
             :  
             :  IMPORTANT VARIABLES FOR EXECUTION
             :  
             :  serviceURL - (Must be defined check below) 
             :    for production use serviceURL = "http://softwarecommunity.intel.com";
             :  
             :  CBCommentPath - (Can Override) Allows comments to be Grouped
             :       based on a path so.....
             :    Saved URLs can take two forms if you use CBCommentPath
             :       ex. - "http://kpirkl-desk.amr.corp.intel.com" + "/test/test2/"
             :    If left alone comments are stored via the full URL 
             :       ex. - "http://kpirkl-desk.amr.corp.intel.com/vdir/test.aspx"
             :
             :  thisURL - Override to change how comments are retrieved (see CBCommentPath)
             :     VERY IMPORTANT - Variable value matches the URL you are getting Comments for.
             :
             :  CB_Localized - Array of text strings allowing override of text
             :      strings for other languages support
             :
             :  StyleSheet is inline to this file and 
             :
             :  <div id="comments"></div> Placement point for dynamic entry form for new comments
             :
             :  <div id="commentText"></div> Placement point for user comments. If not there no comments displayed
             :
             
*/
if ( typeof(serviceURL) == "undefined")
	var serviceURL = 'http://softwarecommunity.intel.com'; 
	//var serviceURL = 'http://kpirkl-desk.amr.corp.intel.com'; // internal testing only
	//var serviceURL = 'http://orisndev01.amr.corp.intel.com';  // internal testing only

// render the StyleSheet
document.writeln("<style>");
document.writeln(".CB_SharedStyle {font-size:11px; font-family:Verdana;}");
document.writeln(".CB_LMargin {margin:5px;}");
document.writeln(".CB_TMargin {padding-top:5px;}");
document.writeln("#CB_Outter {width:300px;border:solid 1px #c0c0c0;}");
document.writeln("#CB_head {font-weight:bold;padding-bottom:5px;}");
document.writeln(".CB_MsgLenError {margin:0px;font-size:10px;color:red;}");
document.writeln(".CB_Buttons {text-align:right; padding-right:5px;}");
document.writeln(".CB_EmailNotDisplayed {font-size:10px;color:666666;}");
document.writeln(".CB_ProtectedByMsg {font-size:10px;color:666666;}");
document.writeln(".CB_CommentBox {width:275px;font-size:11px;font-family:Verdana}");
document.writeln(".CB_TextBox {width:275px;font-size:11px;font-family:Verdana}");
document.writeln("</style>");

var CB_thisUrlNotSet = typeof(thisURL) == "undefined";
if (CB_thisUrlNotSet)
	var thisURL = document.location.protocol + "//" + document.location.hostname + document.location.pathname;

var CBCommentPath = "";
var CB_Original;
var CB_Defined = true;
var CB_Added = false;
var CB_Required = { // validate in reverse for focus order as onscreen...
	cb_cmnt:true,
	cb_email:true,
	cb_name:true};
var CB_Localized = {
		leaveacomment:'Leave a comment',
		name:'Your Name',
		email:'Email <font class="CB_EmailNotDisplayed">(not displayed - keep spam away)</font>',
		comments:'Comments',
		submit:'Submit',
		submitting:'Submitting...',
		cancel:'Cancel',
		postcomment:'Post Comment',
		cb_cmnt:'Please Enter Comment',
		cb_name:'Please Enter Name',
		lengthTooLong:'(Comments are too long please shorten)',
		spamPost:'(Post is spam)', 
		protect:'<font class="CB_ProtectedByMsg">(Protected by <a href=http://akismet.com/>Akismet</a> AntiSpam tools)<br><br>Usage governed by <a target=_blank href=http://softwarecommunity.intel.com/articles/eng/1517.htm>Terms of Use</a></font>',
		lengthAllowed:1500
	};
var CB_T = function(t){return CB_Localized[t]||t;}
var CB_GetS = function(){getData(serviceURL+"/isn/home/CommonServices.ashx?F=GetS");}
var CB_PutS = function(P1){getData(serviceURL+"/isn/home/CommonServices.ashx?F=PutS&P1=" + P1 );}

var CB_maxL = CB_T('lengthAllowed');

function cbPostBackData()
{
	var cmTmp = "____________________________________";
	if (CB_Original != null)
		cmTmp = CB_Original;

	var p = {p:cmTmp,cpath:CBCommentPath,url:thisURL};
	for (var j in CB_Required) 
		p[j] = $('#' + j).val(); 
	var jsontxt = Object.toJSONString(p);
	jsontxt = encodeURIComponent(jsontxt);
	
	return jsontxt;
}



function cbCount() {
	if ( cbPostBackData().length <= CB_maxL )
		$('#CB_LenError').hide(); 
	$("#cbLenCounter").html((CB_maxL-cbPostBackData().length).toString());
	return true;
}



function dynAdd()
{
	if ( !CB_Added) {
		CB_Added = true;
		$('#comments').append('<div id=CB_Outter class=CB_SharedStyle><div id="CB_Window" class="CB_LMargin"><div id="CB_head"></div><div id="CB_LenError" class="CB_MsgLenError"></div></div><br clear="all"/></div>');
		$('#CB_head').html(CB_T('leaveacomment')+':<span id=cbLenCounter style="font-weight: normal;"></span> <span style="font-weight: normal;">encoded chars left</span>');
		$('#CB_LenError').html(CB_T('lengthTooLong'));
		$('#CB_LenError').hide();
		$('#CB_Window').append('<div><div class=CB_TMargin>' + CB_T('name') + '</div><input onKeyUp="return cbCount()" type=text maxlength=128 id=cb_name class=CB_TextBox></div>');
		$('#CB_Window').append('<div><div class=CB_TMargin>' + CB_T('email') + '</div><input onKeyUp="return cbCount()" type=text maxlength=128 id=cb_email class=CB_TextBox></div>');
		$('#CB_Window').append('<div><div class=CB_TMargin>' + CB_T('comments') + '</div><textarea onKeyUp="return cbCount()" wrap=hard id=cb_cmnt rows=5 class=CB_CommentBox></textarea></div>');
		$('#CB_Window').append('<div class="CB_Buttons"><input type=button value=Submit id=cb_cmdSubmit class=CB_SharedStyle>&nbsp;<input type=button value=Cancel id=cb_cmdCancel class=CB_SharedStyle>&nbsp;</div><div>' + CB_T('protect') + '</div>');
		$('#cb_cmdSubmit').val(CB_T('submit'));
		$('#cb_cmdCancel').val(CB_T('cancel'));
		$('#CB_Outter').hide();
		$("#cb_cmdSubmit").click(CB_submit);
		$("#cb_cmdCancel").click(CB_cancel);
	} else {
		$('#CB_Outter').show(); CB_GetS();
	}

	$("#cbLenCounter").html(CB_maxL-cbPostBackData().length);
}


function CB_PostEvent(ok)
{
	$('#cb_cmdSubmit').val(CB_T('submit'));
	$('#cb_cmdSubmit').attr("disabled", "");

	if(ok)
	{
		$('#cb_cmnt').val('');
		if (window.getComments && $("#commentText").is("div"))
			getComments();
		CB_cancel();

		// post comment submit action extend	
		if (CB_PostEvent.extend != null) CB_PostEvent.extend();	
	}
	else
		$('#cb_name').prev().append('<font id=cb_nameerr' + ' color=red> ' + CB_T('spamPost') + '</font>');
	
}

function CB_cancel()
{
	for (var j in CB_Required) 
		$('#' + j + 'err').remove();
	$('#CB_LenError').hide();
	$('#CB_Outter').hide();
	CB_Original = null;
}

function CB_submit()
{
	if ( CB_Original == null)
		return;

	$('#cb_cmdSubmit').val(CB_T('submitting'));
	$('#cb_cmdSubmit').attr("disabled", "disabled");

	var totalLen=0;
	var err;
	for (var j in CB_Required) {
		$('#' + j).val($.trim($('#' + j).val()));
		$('#' + j + 'err').remove();
		if ( CB_Required[j] && $('#' + j).val() == "") {
			err = j;
			$('#' + j).prev().append('<font id=' + j + 'err' + ' color=red>*</font>');
		}
	}
	
//	var p = {p:CB_Original,cpath:CBCommentPath,url:thisURL};
//	for (var j in CB_Required) 
//		p[j] = $('#' + j).val(); 
//	var jsontxt = Object.toJSONString(p);
//	var jsontxt = cbPostBackData();

	if (err!=null) $('#' + err).focus();
	if (CB_maxL-cbPostBackData().length < 0) { 
		err=true; 	
		$('#cb_cmdSubmit').val(CB_T('submit'));
		$('#cb_cmdSubmit').attr("disabled", ""); 
		$('#CB_LenError').show(); 
	}
	if (err!=null) return;

	$("head/script#jsonrequest*").remove(); 
	
	CB_PutS(cbPostBackData());

}

// after the page load lets set get the comments and setup the comment data entry form
$(document).ready(function(){
	dynAdd();

	// Check if Override of how comments are stored is turned on
	if ( CBCommentPath.length > 0)
		thisURL = document.location.protocol + "//" + document.location.hostname + CBCommentPath;
	else
		if (CB_thisUrlNotSet)
			thisURL = document.location.protocol + "//" + document.location.hostname + document.location.pathname;

	if (window.getComments && $("#commentText").is("div"))
		getComments();
});



/*
    json.js
    2006-04-28

    This file adds these methods to JavaScript:

        object.toJSONString()

            This method produces a JSON text from an object. The
            object must not contain any cyclical references.

        array.toJSONString()

            This method produces a JSON text from an array. The
            array must not contain any cyclical references.

        string.parseJSON()

            This method parses a JSON text to produce an object or
            array. It will return false if there is an error.
*/
(function () {
    var m = {
            '\b': '\\b',
            '\t': '\\t',
            '\n': '\\n',
            '\f': '\\f',
            '\r': '\\r',
            '"' : '\\"',
            '\\': '\\\\'
        },
        s = {
            array: function (x) {
                var a = ['['], b, f, i, l = x.length, v;
                for (i = 0; i < l; i += 1) {
                    v = x[i];
                    f = s[typeof v];
                    if (f) {
                        v = f(v);
                        if (typeof v == 'string') {
                            if (b) {
                                a[a.length] = ',';
                            }
                            a[a.length] = v;
                            b = true;
                        }
                    }
                }
                a[a.length] = ']';
                return a.join('');
            },
            'boolean': function (x) {
                return String(x);
            },
            'null': function (x) {
                return "null";
            },
            number: function (x) {
                return isFinite(x) ? String(x) : 'null';
            },
            object: function (x) {
                if (x) {
                    if (x instanceof Array) {
                        return s.array(x);
                    }
                    var a = ['{'], b, f, i, v;
                    for (i in x) {
                        v = x[i];
                        f = s[typeof v];
                        if (f) {
                            v = f(v);
                            if (typeof v == 'string') {
                                if (b) {
                                    a[a.length] = ',';
                                }
                                a.push(s.string(i), ':', v);
                                b = true;
                            }
                        }
                    }
                    a[a.length] = '}';
                    return a.join('');
                }
                return 'null';
            },
            string: function (x) {
                if (/["\\\x00-\x1f]/.test(x)) {
                    x = x.replace(/([\x00-\x1f\\"])/g, function(a, b) {
                        var c = m[b];
                        if (c) {
                            return c;
                        }
                        c = b.charCodeAt();
                        return '\\u00' +
                            Math.floor(c / 16).toString(16) +
                            (c % 16).toString(16);
                    });
                }
                return '"' + x + '"';
            }
        };

    Object.toJSONString = function (obj) {
        return s.object(obj);
    };

    //Array.prototype.toJSONString = function (obj) {
    //   return s.array(obj);
    //};
})();

//String.prototype.parseJSON = function () {
//    try {
//        return !(/[^,:{}\[\]0-9.\-+Eaeflnr-u \n\r\t]/.test(
//                this.replace(/"(\\.|[^"\\])*"/g, ''))) &&
//            eval('(' + this + ')');
//    } catch (e) {
//        return false;
//    }
//};
