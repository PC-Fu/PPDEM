/*
File         : ISNFeedbackAPI.js v 1.0.0.0 - ISN Rating API Tool
Description  : This tool bring rating to any web page (type=text/html)
Developed By : Kevin M Pirkl
Release Date : 05-12-2007
             :
Notes        : ISNFeedbackAPI.js supports the ability to send site  
             :  feedback capabilities into any web page.  
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
             :  File - ISNFeedbackAPI.js
             :         src="http://softwarecommunity.intel.com/isn/Home/ISNFeedbackAPI.js"
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
             :        javascript:sfb();
             :
*/

// Render the StyleSheet
document.writeln("<style>");
document.writeln(".jqmFW {display: none;position: fixed;top: 17%;left: 50%;margin-left: -200px; font-family:verdana,sans-serif;font-size: 11px;background-color: #E7E7E7;color: #000000; border:1px solid #6699CC; padding:0px;}");
document.writeln(".FWin {width: 385px;}");
document.writeln(".FTab {width: 100%;}");
document.writeln(".FB_MsgLenError {margin:0px;font-size:10px;color:red;}");
document.writeln("#femail {font-family:verdana,sans-serif;font-size: 11px;}");
document.writeln("#fmessage { width:370px; font-family:verdana,sans-serif;font-size: 11px;}");
document.writeln(".FHead { width: 50%; color:#ffffff; font-family:verdana,sans-serif;font-size: 11px; background-color:#6699CC;}");
document.writeln(".FBody { padding-top:8px; padding-left:8px; text-align:left; width: 100%; font-family:verdana,sans-serif; font-size: 11px;}");
document.writeln("* html .jqmFW {width:238px; position: absolute;top: expression((document.documentElement.scrollTop || document.body.scrollTop) + Math.round(17 * (document.documentElement.offsetHeight || document.body.clientHeight) / 100) + 'px');}");
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
var FB_thisUrlNotSet = typeof(thisURL) == "undefined";
if (FB_thisUrlNotSet)
	var thisURL = document.location.protocol + "//" + document.location.hostname + document.location.pathname;

var FB_Required = { // validate in reverse for focus order as onscreen...
	fmessage:true,
	ftitle:false,
	furl:false,
	femail:true};

var FB_Localized = {
		feedbackhdr:'Feedback For This Page',
		feedbacksaveerror:'Sorry the system is busy, try again later.',
		feedbacksent:'Feedback Sent',
		feedbackemail:'Your email address:',
		feedbackmessage:'Message:',
		feedbacksubmit:'Submit',
		feedbackclose:'Close',
		feedbacklengthTooLong:'(Feedback too long please shorten)',
		feedbacktotallen:1900
	};
var FB_T = function(t){return FB_Localized[t]||t;}

// run after page is entirely done loading
$(document).ready(function() {

	$(document.body).prepend(
			  '<div class="jqmFW" id="fb2">'
			+ '	<div class="FWin" >'
			+ '	<table class=FTab cellpadding=5 cellspacing=0>'
			+ '	<tr><td class="FHead" align=left><b>' + FB_T('feedbackhdr') + '</b>&nbsp;&nbsp;</td><td align=right class="FHead"><a href="#" class="jqmClose" style="color: #ffffff;">' + FB_T('feedbackclose') + '</a></td></tr>'
			+ '	<tr><td colspan="2" class="FBody">'
			+ '		<div id="FB_LenError" class="FB_MsgLenError"></div>'
			+ '		<div>' + FB_T('feedbackemail') + '</div><input type="text" size="40" maxlength="255" id="femail"><input type="hidden" id="ftitle"><input type="hidden" id="furl"><br><br>'
			+ '		<div>' + FB_T('feedbackmessage') + '</div><TEXTAREA id="fmessage" rows="6"></TEXTAREA>'
			+ '		<br><input type="button" class="groovybutton" onclick="javascript:processFeedback();" value="' + FB_T('feedbacksubmit') + '">'
			+ '	</td><tr>'
			+ '	</table>'
			+ '	</div>'
			+ '</div>'
      );
	$('#FB_LenError').html(FB_T('feedbacklengthTooLong'));
	$('#FB_LenError').hide();

	$('#fb2').jqm({
		overlay:10,
		modal: true,
		onHide: function(hash){
			$('#FB_LenError').hide();
			hash.w.fadeOut('1000',function(){ hash.o.remove(); });
		}
	});
	
});


function sfb(feedbackTitle, feedbackURL)
{
	if ( arguments.length == 0)
	{
		$("#ftitle").val(document.title);
		$("#furl").val(thisURL);
	}

	//$("#fmessage").val("");
	$("#fb2").jqm().jqmShow();
}



//User clicked on the Submit Feedback Button
function processFeedback()
{
	// P1=encodeURIComponent()
	// P2=
	// P3=

	var err;
	for (var j in FB_Required) {
		$('#' + j).val($.trim($('#' + j).val()));
		$('#' + j + 'err').remove();
		if ( (j == "femail" && !isValidEmail($("#femail").val())) || (FB_Required[j] && $('#' + j).val() == "")) {
			err = j;
			$('#' + j).prev().append('<font id=' + j + 'err' + ' color=red>*</font>');
		}
	}

	var sendQS = "";
	sendQS += ("&P1=" + escape($('#fmessage').val()));
	sendQS += ("&P2=" + escape($('#ftitle').val()));
	sendQS += ("&P3=" + escape($('#furl').val()));
	sendQS += ("&P4=" + escape($('#femail').val()));

	if (err!=null) $('#' + err).focus();
	if (sendQS.length>FB_T('feedbacktotallen')) { err=true; $('#FB_LenError').show(); }
	if (err!=null) return;

	getData(serviceURL + "/isn/home/CommonServices.ashx?F=ProcessFeedback" + sendQS);
}

function processFeedbackCallback(fbDataSaved)
{
	if ( !fbDataSaved)
		alert(FB_T('feedbacksaveerror'));
	else
	{
		alert(FB_T('feedbacksent')); // worked and saved
		$("#fmessage").val("");
		$("#fb2").jqmHide();
	}
}

// very simple email check
function isValidEmail(str) {
	return (str.indexOf(".") > 2) && (str.indexOf("@") > 0);
}

