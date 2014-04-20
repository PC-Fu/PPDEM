if ($.browser.msie) {
 document.writeln("<style>* html .jqmWindow {width:238px; position: absolute;top: expression((document.documentElement.scrollTop || document.body.scrollTop) + Math.round(17 * (document.documentElement.offsetHeight || document.body.clientHeight) / 100) + 'px');}</style>");
}

var langDefault = "eng";

if(typeof(thisURL) == "undefined") {
 var thisURL = (document.location.protocol + "//" + document.location.host + document.location.pathname).replace('www3', 'www');
}
if(typeof(thisFullURL) == "undefined") {
 var thisFullURL = encodeURIComponent((document.location.protocol + "//" + document.location.host + document.location.pathname + document.location.search).replace('www3', 'www'));
}
if(typeof(serviceURL) == "undefined") {
 var serviceURL = 'http://softwarecommunity.intel.com';
}
if(typeof(loginURL) == "undefined") {
 var loginURL = 'https://fm1cedar.cps.intel.com/isn/Login/Template.aspx';
}

// Autologin code for combined.js
// In the case where your logged into Intel.com using SiteMinder but not logged into our website.
// This code can run for everyone
if ( get_cookie("SMSESSION")!="" && get_cookie("SMIDENTITY") != ""){
    if ( get_cookie("ISNUSER")=="" || get_cookie("UserRoles")==""){
        document.location = "https://fm1cedar.cps.intel.com/isn/Login/LoginLite.aspx?Lang=ENG&TARGET="+encodeURIComponent(thisURL);
    }
}

// initial page setup and loading login.php
$(function() {
	$("ul.nav").superfish({
		hoverClass : "sfHover",
		delay : 5,
		animation : { opacity: "show" },
		speed : 1
	});
	$("#nav li").hover(
		function() {
			$("ul", this).bgIframe({opacity:true});
		},
		function() { }
	);
	$("#q").focus(function() {
		$(this).val('');
	});
	$("#hLang").change(function() {
		var url = $(this).val();
		if(url != '#') {
			document.location = url;
		}
	});
});

function validate_email(e) {
	var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
	return reg.test(e);
}

function getData(url) {
 $.getScript(url);
}
function digg() {
 document.location = 'http://www.digg.com/submit?phase=2&url='+encodeURIComponent(thisURL);
}
function delicious() {
 document.location = 'http://del.icio.us/post?url='+encodeURIComponent(thisURL);
}
function flash(url, w, h) {
 var id = 'id' + Math.random();
 document.write('<div id="'+id+'" style="height: '+h+'px; width: '+w+'px"></div>');
 var FO = {wmode:"transparent",xi:"true",movie:url,id:"mediaplayer",name:"mediaplayer",width:w,height:h,majorversion:"8",build:"0",bgcolor:"#fff",allowfullscreen:"true",flashvars:"" };
 UFO.create(FO, id);
}
function isValidEmail(str) {
 return (str.indexOf(".") > 2) && (str.indexOf("@") > 0);
}
function setcookie(name,value,path,domain,secure) {
	var cookie_string = name+"="+escape(value);
	var expires = new Date (2020, 01, 01);
	cookie_string += "; expires=" + expires.toGMTString();
	if(path) {
		cookie_string += "; path=" + escape (path);
	}
  if ( domain ) {
        cookie_string += "; domain=" + escape ( domain );
	}
	if(secure) {
		cookie_string += "; secure";
	}
	document.cookie = cookie_string;
}
function delete_cookie(cookie_name) {
	var cookie_date = new Date();
	cookie_date.setTime(cookie_date.getTime() - 1);
	document.cookie = cookie_name += "=; expires=" + cookie_date.toGMTString();
}
function get_cookie(cookie_name) {
	var results = document.cookie.match(cookie_name + '=(.*?)(;|$)');
	if(results) {
		return (unescape(results[1]));
	} else {
		return "";
	}
}

// -----------------------------------------------------------------
// ------------------Download Tracking Code-------------------------
document.writeln("<style>");
document.writeln(".jqmisnDL {display: none;position: fixed;top: 17%;left: 50%;margin-left: -200px; font-family:verdana,sans-serif;font-size: 11px;background-color: #E7E7E7;color: #000000; border:1px solid #6699CC; padding:0px;z-index:99999}");
document.writeln(".isnDL {width: 250px;}");
document.writeln(".ISNTabDL {width: 100%;}");
document.writeln("#txtEmailDL {font-family:verdana,sans-serif;font-size: 11px;}");
document.writeln(".ISNHeadDL {padding:4px; width:50%; color:#ffffff; font-family:verdana,sans-serif;font-size: 11px; background-color:#6699CC;}");
document.writeln(".ISNBodyDL {padding-bottom:8px;padding-top:8px; padding-left:8px; text-align:left; width: 100%; font-family:verdana,sans-serif; font-size: 11px;}");
if ($.browser.msie) {
 document.writeln("* html .jqmisnDL {position: absolute;top: expression((document.documentElement.scrollTop || document.body.scrollTop) + Math.round(17 * (document.documentElement.offsetHeight || document.body.clientHeight) / 100) + 'px');}");
}
document.writeln("</style>");

var isnDL_RequiredField = { // validate in reverse for focus order as onscreen...
 txtEmailDL:true
 };

var isnDL_FileName = "";

var isnDL_Localized = {
  isnDLhdr:'Download',
  txtEmailDL:'Email:',
  isnDLAccept:' Accept ',
  isnDLTOS:'Usage governed by <a id="isnDLTOS" target=_blank href=http://softwarecommunity.intel.com/articles/eng/1517.htm>Terms of Use</a>',
  isnLclose:'Close'
 };

var isnDL_T = function(t){return isnDL_Localized[t]||t;}

// run after page is entirely done loading
$(function() {
 $(".freedownload").each(function(){
      $(this).attr("filename",$(this).attr("href"));
      $(this).attr("href","javascript:void(0);");

 	  if ( $(this).hasClass("embed"))
 	  {
        if ($("#txtEmailDL2").length == 0)
          $(this).before('<span id="txtEmailDLtext">' + isnDL_T('txtEmailDL') + '</span> <input id="txtEmailDL2" type="text" /><br/><br/>');
        $(this).click(function(){
          if ($(this).hasClass("emailrequired"))
          {
            if ($('#txtEmailDL2').val().length == 0)
            {
              $("#txtEmailDLtext").html(isnDL_T('txtEmailDL') + '<font color=red>*</font>');
              return false; // <---  Error, exit without download
            }
          }
          getDL_File($(this).attr("filename").replace(" ","").toLowerCase());
          return true;
        });
 	  }
 	  else
 	  {
        $(this).click(function(){
          isnDL($(this).attr("filename").replace(" ","").toLowerCase(),$(this).hasClass("emailrequired"),$(this).attr("title"));
        });
 	  }
 });

 $(document.body).prepend(
     '<div class="jqmisnDL" id="isnDLb2">'
   + ' <div class="isnDL" >'
   + ' <table class=ISNTabDL cellpadding=5 cellspacing=0>'
   + ' <tr><td class="ISNHeadDL" align=left><b>' + isnDL_T('isnDLhdr') + '</b>&nbsp;&nbsp;</td><td  style="text-align:right;" align="right" class="ISNHeadDL"><a href="#" class="jqmClose" style="color: #ffffff;">' + isnDL_T('isnLclose') + '</a></td></tr>'
   + ' <tr><td colspan="2" class="ISNBodyDL">'
   + '  <div>' + isnDL_T('txtEmailDL') + '</div><input type="text" size="35" maxlength="255" id="txtEmailDL" name="txtEmailDL"><br>'
   + '  <input type="button" class="groovybutton" style="margin-top:4px;" onclick="javascript:validateDLData();" value="' + isnDL_T('isnDLAccept') + '">'
   + '  <div id="isnDLTOSDiv" style="padding-top:5px;">' + isnDL_T('isnDLTOS') + '</div>'
   + ' </td><tr>'
   + ' </table>'
   + '<input type="hidden" name="qlogin" value="true">'
   + ' </div>'
   + '</div>');

 $('#isnDLb2').jqm({
  overlay:10,
  modal: true,
  onHide: function(hash){
   $('#isnDL_LenError').hide();
   hash.w.fadeOut('1000',function(){ hash.o.remove(); });
  }
 });

});

function isnDL(dl_FileName,dl_EmailRequired,dl_TOSAlternate)
{
 isnDL_FileName = dl_FileName;
 isnDL_RequiredField["txtEmailDL"] = dl_EmailRequired;
 if ( dl_TOSAlternate && dl_TOSAlternate.toLowerCase().indexOf("http://") > -1)
     $("#isnDLTOS").attr("href",dl_TOSAlternate);
 $("#txtEmailDL").val("");
 $("#isnDLb2").jqm().jqmShow();
 $("#txtEmailDL").focus();
}

function validateDLData()
{
 var err;
 for (var j in isnDL_RequiredField) {
  $('#' + j).val($.trim($('#' + j).val()));
  $('#' + j + 'err').remove();
  if ( isnDL_RequiredField[j] && $('#' + j).val() == "") {
   err = j;
   $('#' + j).prev().append('<font id=' + j + 'err' + ' color=red>*</font>');
  }
 }
 if (err!=null) $('#' + err).focus();
 if (err==null) getDL_File(isnDL_FileName)
 return (err==null);
}

function getDL_File(isnDL_FileName)
{
	// site catalyst code goes here.
    var url = thisURL;
    if(url.length > 96){
	url = url.substring(0,96);
    }
    var wa_customStuff =
      "wa_custom48=" + document.referrer
    + "&wa_custom08=" + $("#txtEmailDL").val()
    + "&wa_custom09=" + url
    + "&wa_eCustom22=" + $("#txtEmailDL").val()
    + "&wa_events=se_cust22";
    waTrackAsLink(isnDL_FileName,"d", wa_customStuff,"N");
    if (isnDL_FileName.indexOf('http')==0)
      window.open(isnDL_FileName,"file");
    else
      window.open('http://softwarecommunity.intel.com/isn/Downloads/' + isnDL_FileName,"file");
}


// -----------------------------------------------------------------
// ------------------Email a Friend---------------------------------
document.writeln("<style>");
document.writeln(".jqmEF {display: none;position: fixed;top: 17%;left: 50%;margin-left: -200px; font-family:verdana,sans-serif;font-size: 11px;background-color: #E7E7E7;color: #000000; border:1px solid #69C; padding:0px;z-index:99999}");
document.writeln(".EFin {width: 385px;}");
document.writeln(".FTab {width: 100%;}");
document.writeln(".EF_MsgLenError {margin:0px;font-size:10px;color:red;}");
document.writeln("#eafmessage, #eafsubject, #eafemail, #eafrecipentemail {font-family:verdana,sans-serif;font-size: 11px;}");
document.writeln("#eafmessage {width:370px;}");
document.writeln(".FHead { width: 50%; color:#ffffff; font-family:verdana,sans-serif;font-size: 11px; background-color:#69C;}");
document.writeln(".FBody { padding-top:8px; padding-left:8px; text-align:left; width: 100%; font-family:verdana,sans-serif; font-size: 11px;}");
if ($.browser.msie) {
	document.writeln("* html .jqmEF {width:238px; position: absolute;z-index:99999;top: expression((document.documentElement.scrollTop || document.body.scrollTop) + Math.round(17 * (document.documentElement.offsetHeight || document.body.clientHeight) / 100) + 'px');}");
}
document.writeln("</style>");

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

$(function() {
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

function eaf(eafTitle, eafURL) {
	if(arguments.length == 0) {
		$("#eafsubject").val(document.title);
		$("#eafurl").val(thisURL);
	}
	$("#efb2").jqm().jqmShow();
}

function processEAF() {
	var err;
	for (var j in EF_Required) {
		$('#' + j).val($.trim($('#' + j).val()));
		$('#' + j + 'err').remove();
		if ( ( (j == "eafemail" || j == "eafrecipentemail") && !isValidEmail($("#" + j).val())) || (EF_Required[j] && $('#' + j).val() == "")) {
			err = j;
			$('#' + j).prev().append('<font id=' + j + 'err' + ' color=red>*</font>');
		}
	}

	/*var sendQS = "";
	sendQS += ("&P1=" + encodeURIComponent($('#eafmessage').val()));
	sendQS += ("&P2=" + encodeURIComponent($('#eafsubject').val()));
	sendQS += ("&P3=" + encodeURIComponent($('#eafurl').val()));
	sendQS += ("&P4=" + encodeURIComponent($('#eafemail').val()));
	sendQS += ("&P5=" + encodeURIComponent($('#eafrecipentemail').val()));

	if (err!=null) $('#' + err).focus();
	if (sendQS.length>EF_T('eaftotallen')) { err=true; $('#EF_LenError').show(); }
	if (err!=null) return;*/
	$.post("/services/processeaf/rnd="+Math.random(),{eaf_message:encodeURIComponent($('#eafmessage').val()),
							  eaf_subject:encodeURIComponent($('#eafsubject').val()),
							  eaf_url:encodeURIComponent($('#eafurl').val()),
							  eaf_from_email:encodeURIComponent($('#eafemail').val()),
							  eaf_to_email:encodeURIComponent($('#eafrecipentemail').val())
							 }, function(data){
								processEAFCallback(data);
							 });

        //getData(serviceURL + "/isn/home/commonServices.ashx?F=ProcessEAF" + sendQS);
}

function processEAFCallback(eafDataSaved) {
	if(!eafDataSaved) {
		alert(EF_T('eafsaveerror'));
	} else {
		alert(EF_T('eafsent')); // worked and saved
		$("#efb2").jqmHide();
	}
}


// -----------------------------------------------------------------
// ----------------Submit Feedback----------------------------------
document.writeln("<style>");
document.writeln(".jqmFW {display: none;position: fixed;top: 17%;left: 50%;margin-left: -200px; font-family:verdana,sans-serif;font-size: 11px;background-color: #E7E7E7;color: #000000; border:1px solid #69C; padding:0px;z-index: 99999}");
document.writeln(".FWin {width: 385px;}");
document.writeln(".FTab {width: 100%;}");
document.writeln(".FB_MsgLenError {margin:0px;font-size:10px;color:red;}");
document.writeln("#femail {font-family:verdana,sans-serif;font-size: 11px;}");
document.writeln("#fmessage { width:370px; font-family:verdana,sans-serif;font-size: 11px;}");
document.writeln(".FHeadL,.FHeadR { color:#ffffff; font-family:verdana,sans-serif;font-size: 11px; background-color:#69C;}");
document.writeln(".FHeadL {width:75%;} .FHeadR {width:25%;} .FBody { padding-top:8px; padding-left:8px; text-align:left; width: 100%; font-family:verdana,sans-serif; font-size: 11px;}");
if ($.browser.msie) {
	document.writeln("* html .jqmFW {width:238px; position: absolute;top: expression((document.documentElement.scrollTop || document.body.scrollTop) + Math.round(17 * (document.documentElement.offsetHeight || document.body.clientHeight) / 100) + 'px');}");
}
document.writeln("</style>");

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

var FB_maxL = FB_T('feedbacktotallen');

function fbPostBackData() {
	var sendQS = "";
	sendQS += ("&P1=" + encodeURIComponent($('#fmessage').val()));
	sendQS += ("&P2=" + encodeURIComponent($('#ftitle').val()));
	sendQS += ("&P3=" + encodeURIComponent($('#furl').val()));
	sendQS += ("&P4=" + encodeURIComponent($('#femail').val()));
	return sendQS;
}

function fbCount() {
	if(fbPostBackData().length <= FB_maxL) {
		$('#FB_LenError').hide();
	}
	$("#fbLenCounter").html((FB_maxL-fbPostBackData().length).toString());
	return true;
}

$(function() {
	$(document.body).prepend(
			  '<div class="jqmFW" id="fb2">'
			+ '	<div class="FWin" >'
			+ '	<table class=FTab cellpadding=5 cellspacing=0>'
			+ '	<tr><td class="FHeadL" align=left><b>' + FB_T('feedbackhdr') + '</b>:<span id=fbLenCounter></span></td><td align=right class="FHeadR"><a href="#" class="jqmClose" style="color: #ffffff;">' + FB_T('feedbackclose') + '</a></td></tr>'
			+ '	<tr><td colspan="2" class="FBody">'
			+ '		<div id="FB_LenError" class="FB_MsgLenError"></div>'
			+ '		<div>' + FB_T('feedbackemail') + '</div><input onKeyUp="return fbCount()" type="text" size="40" maxlength="255" id="femail"><input type="hidden" id="ftitle"><input type="hidden" id="furl"><br><br>'
			+ '		<div>' + FB_T('feedbackmessage') + '</div><TEXTAREA onKeyUp="return fbCount()" id="fmessage" rows="6"></TEXTAREA>'
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

function sfb(feedbackTitle, feedbackURL) {
	if(arguments.length == 0) {
		$("#ftitle").val(document.title);
		$("#furl").val(thisURL);
	}
	$("#fbLenCounter").html(FB_maxL-fbPostBackData().length);
	$("#fb2").jqm().jqmShow();
}

function processFeedback() {
	$('#FB_LenError').hide();
	var err;
	for (var j in FB_Required) {
		$('#' + j).val($.trim($('#' + j).val()));
		$('#' + j + 'err').remove();
		if ( (j == "femail" && !isValidEmail($("#femail").val())) || (FB_Required[j] && $('#' + j).val() == "")) {
			err = j;
			$('#' + j).prev().append('<font id=' + j + 'err' + ' color=red>*</font>');
		}
	}
	if (err!=null) $('#' + err).focus();
	if (FB_maxL-fbPostBackData().length < 0) { err=true; $('#FB_LenError').show(); }
	if (err!=null) return;
	$.post("/services/processfeedback/rnd="+Math.random(),{
								feedback_message:encodeURIComponent($('#fmessage').val()),
								feedback_title:encodeURIComponent($('#ftitle').val()),
								feedback_url:encodeURIComponent($('#furl').val()),
								feedback_from_email:encodeURIComponent($('#femail').val())
							       }, function(data){
									processFeedbackCallback(data);
								});
								
}

function processFeedbackCallback(fbDataSaved) {
	if(!fbDataSaved) {
		alert(FB_T('feedbacksaveerror'));
	} else {
		alert(FB_T('feedbacksent'));
		$("#fmessage").val("");
		$("#fb2").jqmHide();
	}
}

// -----------------------------------------------------------------
// -----------------------------------------------------------------
function AlternateRowColors() {
  this.allTables = [];
  this.arcTables = [];
  this.firstRow = true;
  this.old_onload = window.onload;
  window.onload = this.init;
  window.arcReference = this;
};

AlternateRowColors.prototype.noFirstRow = ARC_noFirstRow;
AlternateRowColors.prototype.init = ARC_init;

function ARC_init() {
  if(!document.getElementsByTagName) { return; };
  var ARC = window.arcReference;
  ARC.thisType = "";
  ARC.allTables = document.getElementsByTagName("table");
  for(var i=0; i<ARC.allTables.length; i++) {
    if(ARC.allTables[i].className.toLowerCase().substring(0,11) == "tableformat") {
      ARC.arcTables = ARC.arcTables.concat(ARC.allTables[i]);
      ARC.thisType = ARC.allTables[i].className.toLowerCase();
    }
  }
  if(ARC.arcTables.length < 1) { return; };
  for(var jab=0; jab<ARC.arcTables.length; jab++) {
    var table = ARC.arcTables[jab];
    if(ARC.firstRow) {
      table.rows[0].className = ARC.thisType + "FirstRow";
      for(colCount=0; colCount<table.rows[0].cells.length-1; colCount++) {
         table.rows[0].cells[colCount].className = ARC.thisType + "FirstRowCol";
      }
    };
    var rowCount;
    (ARC.firstRow) ? (rowCount = 1) : (rowCount = 0);
    for(rowCount; rowCount<table.rows.length; rowCount++) {
      var tableRow = table.rows[rowCount];
      (rowCount%2 == 0) ? (tableRow.className = ARC.thisType + "RowEven") : (tableRow.className = ARC.thisType + "RowOdd");
      for(colCount=0; colCount<tableRow.cells.length; colCount++) {
         var tableCol = tableRow.cells[colCount];
         tableCol.className = ARC.thisType + "Col";
      }
    }
  }
};

function ARC_noFirstRow() { this.firstRow = false; };

var ARC = new AlternateRowColors();

function goto(u) {
 window.location = u.options[u.options.selectedIndex].value;
}

// Autologin code for combined.js
// In the case where your logged into Intel.com using SiteMinder but not logged into our website.
// This code can run for everyone
if ( get_cookie("SMSESSION")!="" && get_cookie("SMIDENTITY") != "")
{
    if ( get_cookie("ISNUSER")=="" || get_cookie("UserRoles")=="")
    {
        document.location = "https://fm1cedar.cps.intel.com/isn/Login/LoginLite.aspx?Lang=ENG&TARGET="+encodeURIComponent(thisURL);
    }
}

