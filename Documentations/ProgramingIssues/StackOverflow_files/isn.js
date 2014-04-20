function w(ref, height, width, scrollbar) {
 if (scrollbar == "true") { scrollbar = "yes"; } else { scrollbar = "no"; }
 window.open(ref+"?page="+thisURL+"&title="+document.title+"&lang=eng","w1","width="+width+",height="+height+",resizable=no,scrollbars="+ scrollbar+",toolbar=no,location=no,status=no,menubar=no");
}

function comment() {
 window.open(serviceURL+"/ISNCommunication/comment.aspx?page="+thisURL+"&title="+document.title+"&lang=eng","w2","width=420,height=370,resizable=no,scrollbars=yes,toolbar=no,location=no,status=no,menubar=no");
}

function vote(score) {
 window.open(serviceURL+"/ISNRatingWeb/ThankYou.aspx?rurl="+thisURL+"&rt="+score+"&ppu="+thisURL+"&lang=eng","ISNRate","width=325,height=250,resizable=0,scrollbars=0");
}

function tag(ref) {
 window.open(serviceURL+"/ISNTagWeb/ISNTagIT.aspx?turl="+thisURL+"&tdec="+document.title+"&taID=1&Lang=eng","ISNTag","width=700,height=400,resizable=0,scrollbars=1");
}

function p(url) {
 window.open(thisURL+"?prn=Y&"+location.search.substring(1),"prnWindow","toolbar=yes,status=no,height=600,width=780,scrollbars=yes");
}

function getData(url) {
 $.getScript(url);
}

function getComments() {
 $.getScript(serviceURL+"/isn/home/CommonServices.ashx?F=GetCommentsJSON&P1="+thisURL+"&P2=");
}

function getCommentsCallback(jRawData) {
 $("#commentText").html("");
 if(!jRawData) { return; }
 var jData = eval('(' + jRawData + ')');
 if(!jData) { return; }
 if(getCommentsCallback.extend != null) {
  getCommentsCallback.extend(jData);
 }
 var commentText = '';
 var display = '<div style="background: #efefef">%%email%% (%%date%%) wrote:</div><br />%%text%%<br /><br />';
 var len = jData.comments.length;
 if(len > 0) {
  for(i=0;i<len;i++) {
   if(jData.comments[i].email.length > 0) {
    var thisRow = display;
    thisRow = thisRow.replace("%%email%%",unEscape(jData.comments[i].email));
    thisRow = thisRow.replace("%%date%%",unEscape(jData.comments[i].date));
    thisRow = thisRow.replace("%%text%%",unEscape(jData.comments[i].text));
    commentText += thisRow;
   }
  }
  $("#commentText").html(commentText);
 }
}

function unEscape(psEncodeString) {
 var lsRegExp = /\+/g;
 return decodeURIComponent(String(psEncodeString).replace(lsRegExp, " "));
}

function getRating() {
 $.getScript(serviceURL+"/isn/home/CommonServices.ashx?F=GetRatingJSON&P1="+thisURL+"&P2=eng");
}

function getRatingCallback(jData) {
 if(!jData) { return; }
 if(getRatingCallback.extend != null) {
  getRatingCallback.extend(jData);
 }
 var voteText = '%%count%% users have voted, with a combined score of %%score%%.';
 voteText = voteText.replace('%%count%%',jData.RateCount);
 voteText = voteText.replace('%%score%%',jData.Rating);
 $("#voteText").html(voteText);
}

function getTags() {
 $.getScript(serviceURL+"/isn/home/CommonServices.ashx?F=GetTagsJSON&P1=0&P2=15&P3=eng");
}

function getTagsCallback(jData) {
 if(!jData) { $("#tagsText").html(""); return; }
 if(getTagsCallback.extend != null) {
  getTagsCallback.extend(jData);
 }
 var tagsText = '';
 var display = '<a href="%%url%%" class="font%%weight%%">%%tag%%</a>&#160; ';
 var len = jData.length;
 if(len > 0) {
  for(i=0;i<len;i++) {
   if(jData[i].TagName.length > 2) {
    var thisRow = display;
    thisRow = thisRow.replace('%%tag%%',jData[i].TagName);
    thisRow = thisRow.replace('%%weight%%',jData[i].TagWeight);
    thisRow = thisRow.replace('%%url%%',jData[i].TagUrl);
    tagsText += thisRow;
   }
  }
  $("#tagsText").html(tagsText + "<br /><br />");
 }
}

function getTagsForUrl() {
 $.getScript(serviceURL+"/isn/home/CommonServices.ashx?F=GetTagsForURLJSON&P1="+thisURL+"&P2=15&P3=eng");
}

function getTagsForUrlCallback(jData) {
 if(!jData) {
  $("#tagsForUrlText").html('');
 }
 if(getTagsForUrlCallback.extend != null) {
  getTagsForUrlCallback.extend(jData);
 }
 if(!jData) { return; }
 var tagsForUrlText = '';
 var display = '<a href="%%url%%" class="font%%weight%%">%%tag%%</a>&#160; ';
 var len = jData.length;
 if(len > 0) {
  for(i=0;i<len;i++) {
   if(jData[i].TagName.length > 2) {
    var thisRow = display;
    thisRow = thisRow.replace('%%tag%%',jData[i].TagName);
    thisRow = thisRow.replace('%%weight%%',jData[i].TagWeight);
    thisRow = thisRow.replace('%%url%%',jData[i].TagUrl);
    tagsForUrlText += thisRow;
   }
  }
  $("#tagsForUrlText").html("<div class='sectionHeading'>Tags for this Page</div><div class='sectionBody'>"+tagsForUrlText+"</div>");
 }
}
