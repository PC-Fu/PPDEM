//****************************************************************//
//	Copyright (C) 2008 OnSurvey Inc.
//	Created Date: 02/12/2008 - 2008.6.1e
//****************************************************************//
var onImagesPath='http://www.intel.com/sites/survey/pix2/';
var onCookieName='intelresearch';
var onCookieDomain='.intel.com';
var onCookiePath='/';
var onCookieDuration=90;
var onPopFreq=0.4;
var onPopDelay=2000;
var onPagePop=true;
var onRun=true;


function onClientWidth(){return typeof(window.innerWidth)=='number'?window.innerWidth:dD.documentElement&&dD.documentElement.clientWidth?dD.documentElement.clientWidth:dD.body&&dD.body.clientWidth?dD.body.clientWidth:0;}function onClientHeight(){return typeof(window.innerWidth)=='number'?window.innerHeight:dD.documentElement&&dD.documentElement.clientHeight?dD.documentElement.clientHeight:dD.body&&dD.body.clientHeight?dD.body.clientHeight:0;}function onScrollXY(){var scrOfY=0;if(typeof(window.pageYOffset)=='number')scrOfY=window.pageYOffset;else if(document.body&&(document.body.scrollLeft||document.body.scrollTop))scrOfY=document.body.scrollTop;else if(document.documentElement&&(document.documentElement.scrollLeft||document.documentElement.scrollTop))scrOfY=document.documentElement.scrollTop;return scrOfY;}function ONS_chkIndex(v1){var onsi=v1.split('/');if((onsi[3]=='buy'&&onsi[4]=='')||(onsi[3]=='buy'&&onsi[4].indexOf('index')!=-1))return true;if((onsi[3]=='')||(typeof(onsi[4])=='undefined'&&onsi[3].indexOf('index')!=-1))return true;return false;}function ONS_getObj(n){return dD.getElementById?dD.getElementById(n):dD.all?dD.all[n]:dD.layers[n];}function ONS_getRandom(){var g=Math.random();return g;}function ONS_getSiteID(v1){var siteID=ONS_getCookie('SiteID');if(siteID==null){var t=new Date();siteID=Math.floor(Math.random()*10000000000000)+''+t.getTime();ONS_setCookie('SiteID',siteID,onCookieDuration,24);}return siteID;}function ONS_getURL(v1,v2){if((v1==null)||(v1==''))return'NONE';v1=v1.toString().toLowerCase();return v1.substring(0,(pos=v1.indexOf(v2))>0?pos:v1.length);}function ONS_getParameter(pl,pStr){if((pl==null)||(pl==''))return false;pl=pl.toString().toLowerCase();pStr=pStr+'=';var bpos=pl.indexOf(pStr);if(bpos!=-1){bpos+=pStr.length;var epos=pl.indexOf('&',bpos);if(epos==-1)epos=pl.length;return unescape(pl.substring(bpos,epos));}return"";}function ONS_getCookie(n){var name=n+'=',ca=dD.cookie.split(';');for(var i=0;i<ca.length;i++){var c=ca[i];while(c.charAt(0)==' ')c=c.substring(1,c.length);if(c.indexOf(name)==0)return c.substring(name.length,c.length);}return null;}function ONS_setCookie(n,v,d,h){var t=new Date(),g=v.toString().toLowerCase();t.setTime(t.getTime()+(d*h*60*60*1000));var exp=d?';expires='+t.toGMTString():'';if(g!=""){g=g.replace(/!/g,escape('!'));g=g.replace(/</g,escape('<'));g=g.replace(/}/g,escape('}'));g=g.replace(/#/g,escape('#'));g=g.replace(/;/g,escape(';'));v=g;}dD.cookie=n+'='+v+exp+(onCookieDomain?';domain='+onCookieDomain:'')+';path='+onCookiePath;}function ONS_SiteTrack(){onSiteCount=ONS_getCookie('OnSiteNum');if((onSiteCount=='')||(onSiteCount==null))onSiteCount='0';ONS_SiteSave();}function ONS_FloatFly(id){if(onMD<onMY)onObj.style.top=(onMD+=((onMY-onMDf)/80))+px;if(onML<onMX)onObj.style.left=(onML+=((onMX-onMLf)/80))+px;if((onML<onMX)||(onMD<onMY))setTimeout('ONS_FloatFly(\''+id+'\')',5);else{window.onresize=ONS_Icon;ONS_IconFloat(onMX,-80,id).Fm();}}function ONS_FloatMove(e){var topBrowser=onisIE?'body':'html';var hotBrowser=onisIE?event.srcElement:e.target;while(hotBrowser.id!='onTitleBar'&&hotBrowser.tagName.toLowerCase()!=topBrowser)hotBrowser=onisIE?hotBrowser.parentElement:hotBrowser.parentNode;if(hotBrowser.id=='onTitleBar'){offsetx=onisIE?event.clientX:e.clientX;offsety=onisIE?event.clientY:e.clientY;nowX=parseInt(onObj.style.left);nowY=parseInt(onObj.style.top);onFloatOn=true;dD.onselectstart=function(){return false;};dD.onmousemove=ONS_Float;}return;}function ONS_Float(e){var newX,newY,cX,cY;if(onFloatOn){cX=onisIE?event.clientX:e.clientX;cY=onisIE?event.clientY:e.clientY;newX=nowX+cX-offsetx;newY=nowY+cY-offsety;if(newX>cX&&newX>0)newX=cX-onFloatWidth/2;if(newY<0)newY=0;if(newX<0)newX=0;onObj.style.left=newX+px;onObj.style.top=newY+px;}else{dD.onmousemove=null;dD.onselectstart=null;}return;}function ONS_FloatHide(v1){if(v1)ONS_setCookie(onCookieName,0,onCookieDuration,24);onObj.style.display='none';dD.onselectstart=null;dD.onmouseup=null;dD.onmousedown=null;dD.onmousemove=null;return;}function ONS_FloatInit(id){if(!onisIE){dD.onmousedown=ONS_FloatMove;dD.onmouseup=function(){onFloatOn=false;};}onObj=ONS_getObj(id);onObj.style.left=(onClientWidth()-(onFloatWidth+60))+px;onObj.style.top=20+px;onObj.style.display='block';return;}function ONS_IconFloat(iX,iY,id){var L=ONS_getObj(id);this[id+'O']=L;if(dD.layers)L.style=L;L.nX=L.iX=iX;L.nY=L.iY=iY;L.P=function(x,y){this.style.left=x+px;this.style.top=y+px;};L.Fm=function(){var cX,cY;cX=(this.iX>=0)?0:onClientWidth();cY=onScrollXY();if(this.iY<0)cY+=onClientHeight();this.nX+=(cX+this.iX-this.nX);this.nY+=(cY+this.iY-this.nY);this.P(this.nX,this.nY);onTimerID=setTimeout(this.id+'O.Fm()',33);};return L;}function ONS_Icon(){onMX=onClientWidth()-90;clearTimeout(onTimerID);ONS_IconFloat(onMX,-80,'OnSiteFloatIcon').Fm();}function ONS_IconHide(id){if(eval(onObj))onObj.style.display='none';}function ONS_IconInit(id){var onfly=false;ONS_SiteTrack();onMX=onClientWidth()-90;onMY=onClientHeight()-80;if(eval(onObj)&&onObj.id=='OnSiteFloatWin'){onObj.style.display='none';onMLf=onML=parseInt(onObj.style.left);onMDf=onMD=parseInt(onObj.style.top);onfly=true;}else{onMLf=onClientWidth()-90;onMDf=onClientHeight()-80;}onObj=ONS_getObj(id);onObj.style.left=onMLf+px;onObj.style.top=onMDf+px;onObj.style.display='block';if(onfly)ONS_FloatFly(id);else{window.onresize=ONS_Icon;ONS_IconFloat(onMX,-80,id).Fm();}return;}function ONS_Mini(){onMX=onClientWidth()-330;clearTimeout(onTimerID);ONS_IconFloat(onMX,-200,'OnSite2Survey').Fm();}function ONS_MiniHide(id){if(eval(onObj))onObj.style.display='none';}function softclose(){dD.onform.reset();ONS_MiniHide('OnSite2Survey');onObj=ONS_getObj('OnSiteFloatIcon');onObj.style.display='block';}function ONS_SurveyInit(id){onMX=onClientWidth()-330;onMY=onClientHeight();if(eval(onObj))ONS_IconHide('OnSiteFloatIcon');onSStage=ONS_getCookie(onCookieName+'S');if(onSStage<8&&onSStage!=null){onObj=ONS_getObj(id);onObj.style.display='block';window.onresize=ONS_Mini;ONS_IconFloat(onMX,-200,id).Fm();}return;}function ONS_PopSurvey2(v1){onSStage=ONS_getCookie(onCookieName+'S');if(onSStage<8&&onSStage!=null){onChildWin=window.open('about:blank','On2Survey',onSSetting);ONS_SiteSave('End');dD.onform.target='On2Survey';dD.onform.action=onServerPath;dD.onform.submit();}ONS_MiniHide('OnSite2Survey');return false;}function ONS_PopSurvey(v1){onSStage=ONS_getCookie(onCookieName+'S');if(onSStage<8&&onSStage!=null){onChildWin=window.open(v1+'?onsid='+onSiteID+'&lang='+onKey,'On2Survey',onWSetting);ONS_SiteSave('End');}ONS_IconHide('OnSiteFloatIcon');return false;}function ONS_SubmitInfo(v1,v2,v3,v4){dD.onform.onsid.value=v1;dD.onform.onurl.value=v2;dD.onform.onifo.value=v3;dD.onform.onend.value=v4;if(v4=='true'){dD.onform.stype.value=onSurveyType;dD.onform.RF.value=ONS_getCookie(onCookieName+'C');dD.onform.SL.value=onisIE?navigator.systemLanguage:'';dD.onform.UL.value=navigator.userLanguage;dD.onform.lang.value=onKey;}if(onSurveyType=='0'||(onSurveyType=='1'&&v4!='true')){dD.onform.action=onServerPath;if(onLocation.indexOf('https')==-1)dD.onform.submit();}}function ONS_SiteSave(status){onSStage=ONS_getCookie(onCookieName+'S');var t=new Date();var onSiteTime=Date.UTC(t.getFullYear(),t.getMonth()+1,t.getDate(),t.getHours(),t.getMinutes(),t.getSeconds());var onSiteData=ONS_getCookie('OnSiteData');var onSiteInfo=ONS_getCookie('OnSiteInfo');if(onSiteData==null)onSiteData='';if(onSiteInfo==null)onSiteInfo='';if(status=='End'){if(onSStage<8&&onSStage!=null){var r1=onSiteInfo.substring(onSiteInfo.lastIndexOf('^')+1,onSiteInfo.length);var r=(onSiteTime-r1)/1000;onSiteData=onSiteData+'999'+onSiteInfo.substring(onSiteInfo.indexOf('^'),onSiteInfo.lastIndexOf('^')+1)+r+'^';ONS_setCookie('OnSiteInfo','',-1,24);ONS_setCookie('OnSiteData','',-1,24);ONS_setCookie('OnSiteNum','',-1,24);ONS_setCookie(onCookieName+'S',9,1,2);ONS_SubmitInfo(onSiteID,onLocation,onSiteData,'true');}}else if(onSiteData.length>=500){ONS_setCookie('OnSiteData','',-1,24);ONS_SubmitInfo(onSiteID,onLocation,onSiteData,'false');onSiteData='';ONS_setCookie('OnSiteData',onSiteData,null,null);}else{onSiteCount=parseInt(onSiteCount)+1;var r1=onSiteInfo.substring(onSiteInfo.lastIndexOf('^')+1,onSiteInfo.length);if(r1==''||r1==null)onSiteInfo=onSiteCount+'^'+onLocation+'^'+onSiteTime;else{var r=(onSiteTime-r1)/1000;onSiteData=onSiteData+onSiteInfo.substring(0,onSiteInfo.lastIndexOf('^')+1)+r+'^';onSiteInfo=onSiteCount+'^'+onLocation+'^'+onSiteTime;}ONS_setCookie('OnSiteInfo',onSiteInfo,null,null);ONS_setCookie('OnSiteData',onSiteData,null,null);ONS_setCookie('OnSiteNum',onSiteCount,null,null);}}function ONS_Tags(){var onTagSyntax=[['sites/corporate/tradmarx.htm','sites/corporate/privacy.htm','Provide<BR>Feedback'],['corporate/europe/emea/fra/sites/tradmarx.htm','cd/corporate/europe/emea/fra/180454.htm','Commencer<BR>le<BR>sondage'],['cd/corporate/europe/emea/rus/189530.htm','cd/corporate/europe/emea/rus/180458.htm','&#1053;&#1072;&#1095;&#1072;&#1090;&#1100;<BR>&#1079;&#1072;&#1087;&#1086;&#1083;&#1085;&#1077;&#1085;&#1080;&#1077;<BR>&#1072;&#1085;&#1082;&#1077;&#1090;&#1099;'],['cd/corporate/resources/apac/zho/85060.htm','cd/corporate/resources/apac/zho/85059.htm','&#24320;&#22987;&#35843;&#26597;'],['sites/jp/tradmarx.htm','sites/jp/privacy.htm','&#12450;&#12531;&#12465;&#12540;&#12488;&#12395;&#31572;&#12360;&#12427;'],['cd/corporate/europe/emea/deu/102417.htm','cd/corporate/europe/emea/deu/180453.htm','Umfrage starten'],['sites/portugues/corporate/tradmarx.htm','sites/portugues/corporate/privacy.htm','Iniciar<BR>a<BR>Pesquisa'],['sites/espanol/corporate/tradmarx.htm','sites/espanol/corporate/privacy.htm','Comenzar la b&uacute;squeda'],['cd/corporate/resources/apac/zht/86731.htm','cd/corporate/resources/apac/zht/86730.htm','&#38283;&#22987;&#35519;&#26597;']];var onMsgText='<IMG id="introimage" src="'+onImagesPath+onKey+'Intro.gif" border="0">';var onMsgButt='<IMG src="'+onImagesPath+onKey+'yes.gif" border="0" style="cursor:pointer;" onclick="ONS_InitTrack()">&nbsp;<IMG src="'+onBulletPath+'" border="0">&nbsp;<IMG src="'+onImagesPath+onKey+'no.gif" border="0" style="cursor:pointer;" onclick="ONS_FloatHide(\'1\')">';var onMsgFoot='<A target="_blank" href="http://www.intel.com/'+onTagSyntax[onKey][0]+'"><IMG valign="bottom" src="'+onImagesPath+onKey+'legal.gif" border="0"></A>&nbsp;&nbsp;<A target="_blank" href="http://www.intel.com/'+onTagSyntax[onKey][1]+'"><IMG valign="bottom" src="'+onImagesPath+onKey+'privacy.gif" border="0"></A>';var onTag='<DIV id="OnSiteFloatWin" style="background-color:transparent;z-index:1001;position:absolute;width:'+onFloatWidth+'px;display:none;"><ILAYER width="100%"><LAYER width="100%">';onTag=onTag+'<TABLE width="100%" border="0" cellpadding="0" cellspacing="0" onmousedown="ONS_FloatMove();" onmouseup="onFloatOn=false" id="onTitleBar"><TR><TD background="'+onImagesPath+'t_bar.gif" height="36" style="vertical-align:middle;"><IMG style="float:right;margin-right:10px;cursor:pointer;" border=0 src="'+onImagesPath+'close.gif" onclick="javascript:ONS_FloatHide(\'close\');"></TD></TR></TABLE>';onTag=onTag+'<TABLE width="100%" border="0" cellpadding="0" cellspacing="0"><TR><TD>'+onMsgText+'</TD></TR><TR><TD background="'+onImagesPath+'m_bar.gif" height="16" style="text-align:right;">'+onMsgFoot+'&nbsp;&nbsp;</TD></TR><TR><TD background="'+onImagesPath+'b_bar.gif" height="38" style="text-align:center;">'+onMsgButt+'</TD></TR></TABLE>';onTag=onTag+'</LAYER></ILAYER></DIV>';onTag=onTag+'<DIV id="OnSite2Survey" style="border:2px solid;border-color:#0079bd;z-index:1001;position:absolute;background-color:#FFFFFF;width:300px;display:none;"><ILAYER width="100%"><LAYER width="100%">';onTag=onTag+'<TABLE align=center border=0 cellspacing=0 cellpadding=0 style="font-family:Verdana;font-size:9px;color:#000000;" width="95%">';onTag=onTag+'<FORM method="post" action="'+onServerPath+'" name="onform">';onTag=onTag+'<TR><TD colspan=4 style="line-height:3px">&nbsp;</TD></TR>';onTag=onTag+'<TR><TD colspan=4 style="font-weight:bold;" >Download Center result I needed was found...</TD></TR>';onTag=onTag+'<TR><TD colspan=4><SELECT name=rq1 size=1 style="font-family:Verdana;font-size:9px;width:99%"><OPTION value=-998 selected>Please choose one</OPTION><OPTION value=1>In the top box link</OPTION><OPTION value=2>In the 1st link</OPTION><OPTION value=3>In the 2nd or 3rd link</OPTION><OPTION value=4>After the 3rd link on 1st page</OPTION><OPTION value=5>On the 2nd page</OPTION><OPTION value=6>After the 2nd page</OPTION><OPTION value=7>I <B>DID NOT</B> find the results I was seeking</OPTION></SELECT></TD></TR>';onTag=onTag+'<TR><TD colspan=4 style="line-height:3px">&nbsp;</TD></TR>';onTag=onTag+'<TR><TD style="font-weight:bold;width:150px;">The Download Center...</TD><TD style="text-align:center;"><IMG src="'+onImagesPath+'s1.gif"></TD><TD style="text-align:center;"><IMG src="'+onImagesPath+'s3.gif"></TD><TD style="text-align:center;"><IMG src="'+onImagesPath+'s5.gif"></TD></TR>';onTag=onTag+'<TR><TD>Is easy to use</TD><TD style="text-align:center;"><INPUT type=radio name=rq2 value=1 style="cursor:pointer" title="Disagree"></TD><TD style="text-align:center;"><INPUT type=radio name=rq2 value=3 style="cursor:pointer" title="Neither"></TD><TD style="text-align:center;"><INPUT type=radio name=rq2 value=5 style="cursor:pointer" title="Agree"></TD></TR>';onTag=onTag+'<TR><TD>Results load quickly</TD><TD style="text-align:center;"><INPUT type=radio name=rq3 value=1 style="cursor:pointer" title="Disagree"></TD><TD style="text-align:center;"><INPUT type=radio name=rq3 value=3 style="cursor:pointer" title="Neither"></TD><TD style="text-align:center;"><INPUT type=radio name=rq3 value=5 style="cursor:pointer" title="Agree"></TD></TR>';onTag=onTag+'<TR><TD>Provides accurate results</TD><TD style="text-align:center;"><INPUT type=radio name=rq4 value=1 style="cursor:pointer" title="Disagree"></TD><TD style="text-align:center;"><INPUT type=radio name=rq4 value=3 style="cursor:pointer" title="Neither"></TD><TD style="text-align:center;"><INPUT type=radio name=rq4 value=5 style="cursor:pointer" title="Agree"></TD></TR>';onTag=onTag+'<TR><TD colspan=4 style="font-weight:bold;">Comments</TD></TR>';onTag=onTag+'<TR><TD colspan=4><input type=text name=rq5 style="font-family:Verdana;font-size:9px;width:99%;" maxlength="200"></TD></TR>';onTag=onTag+'<TR><TD colspan=4 style="line-height:3px">&nbsp;</TD></TR>';onTag=onTag+'<input type="hidden" name="stype" value=""><input type="hidden" name="onsid" value=""><input type="hidden" name="onurl" value=""><input type="hidden" name="onifo" value=""><input type="hidden" name="onend" value=""><input type="hidden" name="lang" value=""><input type="hidden" name="SL" value=""><input type="hidden" name="UL" value=""><input type="hidden" name="RF" value="">';onTag=onTag+'</FORM></TABLE><DIV style="text-align:center;height:22px;padding-top:4px;width:100%;background-image:url('+onImagesPath+'s_bar.gif);"><A href="'+onServerPath+'" target="On2Survey" onClick="return ONS_PopSurvey2(this.href);"><IMG border=0 src="'+onImagesPath+'submit.gif"></A>&nbsp;&nbsp;&nbsp;<A href="javascript:softclose();"><IMG border=0 src="'+onImagesPath+'cancel.gif"></A></DIV>';onTag=onTag+'</LAYER></ILAYER></DIV>';onTag=onTag+'<DIV id=OnSiteFloatIcon style="z-index:1001;position:absolute;background-color:transparent;width:60px;font-size:8pt;font-family:verdana;text-align:center;display:none;"><ILAYER width=100%><LAYER width=100%>';if(onSurveyType=='0')onTag=onTag+'<A href="'+onSurveyPath+'" target="OnSiteSurvey" onClick="return ONS_PopSurvey(this.href);" style="color:#0860a8;text-decoration:none" onmouseout="this.style.textDecoration=\'none\'" onmouseover="this.style.textDecoration=\'underline\'"><IMG src="'+onImagesPath+'icon.gif" border="0" style="opacity:0.6;filter:alpha(opacity=70)" alt="Click here to provide feedback!"><BR>'+onTagSyntax[onKey][2]+'</A>';if(onSurveyType=='1')onTag=onTag+'<A href="javascript:ONS_SurveyInit(\'OnSite2Survey\');" style="color:#0860a8;text-decoration:none" onmouseout="this.style.textDecoration=\'none\'" onmouseover="this.style.textDecoration=\'underline\'"><IMG src="'+onImagesPath+'icon2.gif" border="0" style="opacity:0.6;filter:alpha(opacity=70)" alt="Click here to provide feedback!"><BR>Provide<BR>Feedback</A>';onTag=onTag+'</LAYER></ILAYER></DIV>';dD.write(onTag);return true;}function ONS_InitTrack(){ONS_FloatHide(null);if(ONS_getCookie(onCookieName+'S')){window.alert('Sorry, you already have an active survey!');}else{ONS_setCookie(onCookieName,1,onCookieDuration,24);ONS_setCookie(onCookieName+'S',1,1,2);ONS_IconInit('OnSiteFloatIcon');}return;}function ONS_InitPop(){var siteKey=[['/fra/','1'],['/fr/','1'],['/ru/','2'],['/rus/','2'],['/zho/','3'],['/cn/','3'],['/jp/','4'],['/ijkk/','4'],['.jp/','4'],['/deu/','5'],['/de/','5'],['/portugues/','6'],['/portuguese/','6'],['/por/','6'],['/pt/','6'],['/sp/','7'],['/espanol/','7'],['/es/','7'],['/tw/','8'],['/zht/','8']];var siteLang=[['fra','1'],['rus','2'],['zho','3'],['jpn','4'],['deu','5'],['por','6'],['spa','7'],['zht','8']];for(var c=0;c<siteKey.length;c++){if(onLocation.indexOf(siteKey[c][0])!=-1){onKey=siteKey[c][1];break;}}if(onKey==0){var lang=ONS_getParameter(onLocation,'lang');if(lang!=""){for(var c=0;c<siteLang.length;c++){if(lang==siteLang[c][0]){onKey=siteLang[c][1];break;}}}}onAccess=[['downloadcenter','0.75'],['downloadfinder','0.75'],['processormatch','0.75'],['/community/','0.75'],['softwareforums.','0'],['/software/','0'],['/ids/','0'],['/support_intel.','0.75'],['/support/','0.75'],['/shop/','0'],['/sites/corporate/','0'],['/events/webcast','0'],['/capital/','0'],['/feedback','0'],['/siteindex','0'],['/resources/','0'],['/solutions/','0'],['/cd/services/intelsolutionservices/','0'],['/distributor/asmo-na/eng/','1'],['/distributor/emea/eng/','1'],['/distributor/apac/eng/','1'],['/reseller/emea/eng/','1'],['/reseller/apac/eng/','1'],['/distributor/asmo-na/eng/90512','0'],['/distributor/asmo-na/eng/index','1'],['/reseller/asmo-na/eng/','1']];onDisable=['//sienna.','.pcnalert.','serverconfigurator.intel.'];onImage.src=onImagesPath+onKey+'intro.gif';return true;}function ONS_SpecPop(qL,qA,qD,qP){for(var c=0;c<qD.length;c++){if(qL.indexOf(qD[c])!=-1)return false;}if(qP==null){if(onIndexPgr)return false;for(var c=0;c<qA.length;c++){if(qL.indexOf(qA[c][0])!=-1){if((qA[c][1]>onPopFreq&&onPopFreq!=0)||qA[c][1]==0)onPopFreq=qA[c][1];if(onKey==3&&(c==7||c==8))onPopFreq=0;}}}if((qL.indexOf(qA[0][0])!=-1||qL.indexOf(qA[1][0])!=-1)&&onKey==0){var site2=ONS_getCookie('Site2');if((ONS_getRandom()<=0.35&&site2==null)||site2==1)onSurveyType='1';if(site2==null)ONS_setCookie('Site2',onSurveyType,4,24);}return true;}function ONG_Survey(){if(ONS_InitPop()){if(ONS_SpecPop(onLocation,onAccess,onDisable,onSStage)){onTagbln=ONS_Tags();if(onSStage==null){if(ONS_getRandom()<=onPopFreq)window.setTimeout('ONS_FloatInit(\'OnSiteFloatWin\')',onPopDelay);if(!onPagePop)ONS_setCookie(onCookieName,0,onCookieDuration,24);}else if(onSStage<8){ONS_IconInit('OnSiteFloatIcon');}}}}var onSSetting='width=1,height=1,left='+(screen.availWidth+250)+',top=0,resizable=0,scrollbars=0';var onWSetting='width='+(screen.availWidth-150)+',height='+(screen.availHeight-100)+',left=0,top=0,resizable=1,scrollbars=1';var onTagbln=false;var onSA=false;var onMX,onMDf,onMD,onMY,onMLf,onML;var onFloatOn;var onChildWin;var onObj=null;var onImage=new Image();var onBullet=new Image();var dD=document;var nN=navigator;var px=dD.layers?'':'px';var onKey='0';var onAccess,onDisable;var onisNN=(nN.appName.indexOf('Netscape')!=-1);var onisIE=(nN.appName.indexOf('Microsoft')!=-1);var onisOP=(nN.userAgent.toLowerCase().indexOf('opera')>-1)?true:false;var onisNS=(nN.userAgent.toLowerCase().indexOf('mozilla')!=-1)&&(parseInt(nN.appVersion)>=5);var onisMAC=(nN.appVersion.indexOf('Macintosh')>-1);var onFloatWidth=350;var onBulletPath='http://onsite.researchintel.com/images/bulletintel2.gif';var onServerPath='http://onsite.researchintel.com/engine/saveinfo.asp';var onSurveyPath='http://onsite.researchintel.com/engine/savefinal.asp';var onSurveyType='0';var onLocation=ONS_getURL(dD.location,'');var onReferrer=ONS_getURL(dD.referrer,'?');if(onLocation.indexOf('.co.jp')!=-1)onCookieDomain='.intel.co.jp';var onSiteID=ONS_getSiteID();var onIndexPgr=ONS_chkIndex(onLocation);var onSIntel=ONS_getCookie(onCookieName);var onSStage=ONS_getCookie(onCookieName+'S');var onCookie=ONS_getCookie(onCookieName+'C');if((onSIntel!=null&&onSStage!=null)||(onSIntel==null&&onSStage==null))onSA=true;if(onRun&&onSA){if(onCookie){if((onSIntel==1&&(onSStage<8&&onSStage!=null))||onSIntel==null)ONG_Survey();}else ONS_setCookie(onCookieName+'C',onReferrer,1,24);}else{onObj=ONS_getObj('OnSiteFloatIcon');if(onObj)onObj.style.display='none';}