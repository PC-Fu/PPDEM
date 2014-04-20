var FlashDetected = 0;
if (navigator.mimeTypes && navigator.mimeTypes["application/x-shockwave-flash"] &&
	navigator.mimeTypes["application/x-shockwave-flash"].enabledPlugin) {
	if (navigator.plugins && navigator.plugins["Shockwave Flash"])
		FlashDetected  = 1;
}
else if (navigator.userAgent && navigator.userAgent.indexOf("MSIE")>=0 &&
	(navigator.userAgent.indexOf("Windows 95")>=0 || 
	 navigator.userAgent.indexOf("Windows 98")>=0 || 
	 navigator.userAgent.indexOf("Windows NT")>=0)) {
	document.write('<SCRIPT LANGUAGE=VBScript\> \n');
	document.write('on error resume next \n');
	document.write('FlashDetected  = ( IsObject(CreateObject("ShockwaveFlash.ShockwaveFlash.3")))\n');
	document.write('if ( FlashDetected  <= 0 ) then FlashDetected  = ( IsObject(CreateObject("ShockwaveFlash.ShockwaveFlash.9")))\n');
	document.write('if ( FlashDetected  <= 0 ) then FlashDetected  = ( IsObject(CreateObject("ShockwaveFlash.ShockwaveFlash.8")))\n');
	document.write('if ( FlashDetected  <= 0 ) then FlashDetected  = ( IsObject(CreateObject("ShockwaveFlash.ShockwaveFlash.7")))\n');
	document.write('if ( FlashDetected  <= 0 ) then FlashDetected  = ( IsObject(CreateObject("ShockwaveFlash.ShockwaveFlash.6")))\n');
	document.write('if ( FlashDetected  <= 0 ) then FlashDetected  = ( IsObject(CreateObject("ShockwaveFlash.ShockwaveFlash.5")))\n');
	document.write('if ( FlashDetected  <= 0 ) then FlashDetected  = ( IsObject(CreateObject("ShockwaveFlash.ShockwaveFlash.4")))\n');
	document.write('</SCRIPT\> \n');
}

function FlashAdText(FlashAdMovie, FlashAdRedirURL, FlashAdAltImage, FlashAdSizeX, FlashAdSizeY)
{
	var FlashAdText = '';
	if (FlashDetected) {
		FlashAdText += '<OBJECT classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"';
		FlashAdText += '  codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,40,0" ';
		FlashAdText += '  WIDTH=' + FlashAdSizeX + ' HEIGHT=' + FlashAdSizeY + '>';
		FlashAdText += '<PARAM NAME=movie VALUE="' + FlashAdMovie + '?clickTAG=' + FlashAdRedirURL + '&target=_blank">';
		FlashAdText += '<PARAM NAME=quality VALUE=high>'; 
		FlashAdText += '<PARAM NAME=wmode value=opaque>';		
		FlashAdText += '<EMBED src="' + FlashAdMovie + '?clickTAG=' + FlashAdRedirURL + '&target=_blank" quality=high';
		FlashAdText += ' wmode="opaque" WIDTH=' + FlashAdSizeX + ' HEIGHT=' + FlashAdSizeY;
		FlashAdText += ' TYPE="application/x-shockwave-flash" PLUGINSPAGE="http://www.macromedia.com/go/getflashplayer">';
		FlashAdText += '</EMBED>';
		FlashAdText += '</OBJECT>';
	} else if (!(navigator.appName && navigator.appName.indexOf("Netscape")>=0 && navigator.appVersion.indexOf("2.")>=0)){
		FlashAdText += '<a href="' + FlashAdRedirURL + '" target="_blank"><IMG SRC="' + FlashAdAltImage + '" WIDTH=' + FlashAdSizeX + ' HEIGHT=' + FlashAdSizeY + ' BORDER=0></a>';
	}
	return FlashAdText;
}

function RenderFlash(ID, FlashAdMovie, FlashAdRedirURL, FlashAdAltImage, FlashAdSizeX, FlashAdSizeY) {
	// Hack for IE6. Probably not needed. See http://blogs.msdn.com/ie/archive/2007/11/08/ie-automatic-component-activation-changes-to-ie-activex-update.aspx
	var agt = navigator.userAgent.toLowerCase();
	if ((agt.indexOf("msie") >= 0) && (agt.indexOf("opera") < 0) && (agt.indexOf("mac") < 0) &&
	    (parseInt(agt.charAt(agt.indexOf("msie")+5)) == 6)) {
		document.writeln('<div id="f_' + ID + '"></div>');
		ActivateFlash('f_' + ID,FlashAdText(FlashAdMovie, FlashAdRedirURL, FlashAdAltImage, FlashAdSizeX, FlashAdSizeY));
	}
	else
		document.writeln(FlashAdText(FlashAdMovie, FlashAdRedirURL,FlashAdAltImage, FlashAdSizeX, FlashAdSizeY));
}