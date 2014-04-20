/*
File         : ISNEmailAFriendAPI.js v 1.0.0.0 - ISN Rating API Tool
Description  : This tool bring rating to any web page (type=text/html)
Developed By : Kevin M Pirkl
Release Date : 05-12-2007
             :
Notes        : ISNEmailAFriendAPI.js supports the ability to send site  
             :  eaf capabilities into any web page.  
             :
             :  There are a few things to be aware of.
             :
             :  REQUIRED FILES ----------------------------------
             :
             :   The following includes < ----- ******************* VERY IMPORTANT
             :       must be in the order below...  
             :
             :   If you use BlockLibrary then you have jQuery & isn.js already
             : 
             :  File - jquery.js jQuery.com - /isn/Home/jquery.js
             :  File - isn.js referenced at http://cache-www.intel.com/plt/cd/software/shared/eng/dhtml/isn.js
             :  File - jqModal.js http://dev.iceburg.net/jquery/jqModal/
             :         src="http://softwarecommunity.intel.com/isn/Home/jqModal.js"
             :  File - ISNEmailAFriendAPI.js
             :         src="http://softwarecommunity.intel.com/isn/Home/ISNEmailAFriendAPI.js"
             :  
             :  IMPORTANT VARIABLES ----------------------------------
             :  
             :  serviceURL - (Must be defined check below) 
             :    for production use serviceURL = "http://softwarecommunity.intel.com";
             :  
             :  thisURL - Override to change how comments are retrieved
             :     VERY IMPORTANT - Variable value matches the URL you are asking for Feedback for.
             :
             :  EXAMPLE USAGE ----------------------------------
             : 
             :   For a more manual approach use the placement code of found below around the section of code
             :    that looks like the following.
             :        javascript:eaf();
             :
*/

// Render the StyleSheet
document.writeln("<style>");
document.writeln(".jqmEF {display: none;position: fixed;top: 17%;left: 50%;margin-left: -200px; font-family:verdana,sans-serif;font-size: 11px;background-color: #E7E7E7;color: #000000; border:1px solid #6699CC; padding:0px;}");
document.writeln(".EFin {width: 385px;}");
document.writeln(".FTab {width: 100%;}");
document.writeln(".EF_MsgLenError {margin:0px;font-size:10px;color:red;}");
document.writeln("#eafmessage, #eafsubject, #eafemail, #eafrecipentemail {font-family:verdana,sans-serif;font-size: 11px;}");
document.writeln("#eafmessage {width:370px;}");
document.writeln(".FHead { width: 50%; color:#ffffff; font-family:verdana,sans-serif;font-size: 11px; background-color:#6699CC;}");
document.writeln(".FBody { padding-top:8px; padding-left:8px; text-align:left; width: 100%; font-family:verdana,sans-serif; font-size: 11px;}");
document.writeln("* html .jqmEF {width:238px; position: absolute;top: expression((document.documentElement.scrollTop || document.body.scrollTop) + Math.round(17 * (document.documentElement.offsetHeight || document.body.clientHeight) / 100) + 'px');}");
document.writeln(".jqmOverlay { background-color: #262626; }");
document.writeln("a.jqmClose, .jqmClose { color: #ffffff;}");
document.writeln(".groovybutton {background-image:url(http://softwarecommunity.intel.com/videos/images/back03.gif);border:1px solid #DDDDDD;font-family:Verdana,sans-serif;font-size:11px;height:20px;}");
document.writeln("</style>");

// Failsafe catch if serviceURL is not defined
if ( typeof(serviceURL) == "undefined")
	var serviceURL = 'http://softwarecommunity.intel.com'; 
	//var serviceURL = 'http://kpirkl-mobl.amr.corp.intel.com'; // internal testing only
	//var serviceURL = 'http://orisndev01.amr.corp.intel.com';  // internal testing only

// Failsafe catch in case thisUrl is not defined
var EF_thisUrlNotSet = typeof(thisURL) == "undefined";
if (EF_thisUrlNotSet)
	var thisURL = document.location.protocol + "//" + document.location.hostname + document.location.pathname;

var EF_Required = { // validate in reverse for focus order as onscreen...
	eafmessage:true,
	eafsubject:true,
	eafurl:false,
	eafemail:true,
	eafrecipentemail:true
	};

var EF_Localized = {
		eafhdr:'Email This Page',
		eafsaveerror:'Sorry the system is busy, try again later.',
		eafsent:'Email Sent',
		eafheader:'Email this page to your friend. Complete the form below and click on the "send" button. All fields are required to help prevent spam.',
		eafemail:'Your email address:',
		eafrecipentemail:'Recipients email address:',
		eafsubject:'Subject:',
		eafmessage:'Message:',
		eafsubmit:'Submit',
		eafclose:'Close',
		eaflengthTooLong:'(Message too long please shorten)',
		eaftotallen:1900
	};
var EF_T = function(t){return EF_Localized[t]||t;}

// run after page is entirely done loading
$(document).ready(function() {

	$(document.body).prepend(
			  '<div class="jqmEF" id="efb2">'
			+ '	<div class="EFin" >'
			+ '	<table class=FTab cellpadding=5 cellspacing=0>'
			+ '	<tr><td class="FHead" align=left><b>' + EF_T('eafhdr') + '</b>&nbsp;&nbsp;</td><td align=right class="FHead"><a href="#" class="jqmClose" style="color: #ffffff;">' + EF_T('eafclose') + '</a></td></tr>'
			+ '	<tr><td colspan="2" class="FBody">'
			+ '		<div id="EF_LenError" class="EF_MsgLenError"></div>'
			+ '		<div>' + EF_T('eafheader') + '</div><br><br>'
			+ '		<div>' + EF_T('eafrecipentemail') + '</div><input type="text" size="40" maxlength="255" id="eafrecipentemail"><br><br>'
			+ '		<div>' + EF_T('eafemail') + '</div><input type="text" size="40" maxlength="255" id="eafemail"><br><br>'
			+ '		<div>' + EF_T('eafsubject') + '</div><input type="text" size="40" maxlength="255" id="eafsubject"><br><br>'
			+ '		<div>' + EF_T('eafmessage') + '</div><TEXTAREA id="eafmessage" rows="6"></TEXTAREA>'
			+ '		<br><input type="button" class="groovybutton" onclick="javascript:processEAF();" value="' + EF_T('eafsubmit') + '"><input type="hidden" id="eafurl">'
			+ '	</td><tr>'
			+ '	</table>'
			+ '	</div>'
			+ '</div>'
      );
	$('#EF_LenError').html(EF_T('eaflengthTooLong'));
	$('#EF_LenError').hide();

	$('#efb2').jqm({
		overlay:10,
		modal: true,
		onHide: function(hash){
			$('#EF_LenError').hide();
			hash.w.fadeOut('1000',function(){ hash.o.remove(); });
		}
	});
	
});


function eaf(eafTitle, eafURL)
{
	if ( arguments.length == 0)
	{
		$("#eafsubject").val(document.title);
		$("#eafurl").val(thisURL);
	}

	//$("#eafmessage").val("");
	$("#efb2").jqm().jqmShow();
}



//User clicked on the Submit Button
function processEAF()
{
	// P1=encodeURIComponent()
	// P2=
	// P3=

	var err;
	for (var j in EF_Required) {
		$('#' + j).val($.trim($('#' + j).val()));
		$('#' + j + 'err').remove();
		if ( ( (j == "eafemail" || j == "eafrecipentemail") && !isValidEmail($("#" + j).val())) || (EF_Required[j] && $('#' + j).val() == "")) {
			err = j;
			$('#' + j).prev().append('<font id=' + j + 'err' + ' color=red>*</font>');
		}
	}

	var sendQS = "";
	sendQS += ("&P1=" + escape($('#eafmessage').val()));
	sendQS += ("&P2=" + escape($('#eafsubject').val()));
	sendQS += ("&P3=" + escape(unescape(unescape($('#eafurl').val()))));
	sendQS += ("&P4=" + escape($('#eafemail').val()));
	sendQS += ("&P5=" + escape($('#eafrecipentemail').val()));

	if (err!=null) $('#' + err).focus();
	if (sendQS.length>EF_T('eaftotallen')) { err=true; $('#EF_LenError').show(); }
	if (err!=null) return;

	//alert(serviceURL + "/isn/home/CommonServices.ashx?F=ProcessEAF" + sendQS);
	getData(serviceURL + "/isn/home/CommonServices.ashx?F=ProcessEAF" + sendQS);
}

function processEAFCallback(eafDataSaved)
{
	if ( !eafDataSaved)
		alert(EF_T('eafsaveerror'));
	else
	{
		alert(EF_T('eafsent')); // worked and saved
		//$("#eafmessage").val("");
		$("#efb2").jqmHide();
	}
}

// very simple email check
function isValidEmail(str) {
	return (str.indexOf(".") > 2) && (str.indexOf("@") > 0);
}


