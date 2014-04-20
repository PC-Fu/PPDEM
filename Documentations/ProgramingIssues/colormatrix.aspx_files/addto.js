function social() {
	this.txtVersion = "1.2";
	this.addtoInterval = null;
	this.popupWin = '';
	this.addtoMethod=1;
	this.AddTitle=null;
	this.AddURL=null;
	this.Horizontal=false;
	this.Showname=false;
	this.ObjectTypeId=0;
	this.ObjectId=0;
	this.PlaceholderId='';
	
	this.sns=[
	 {name:'Digg',			image: 'AddTo_Digg.png',		url: 'http://digg.com/submit?',				urlVar: 'url',	titleVar: '',		noteVar: '',	returnVar: '',	otherVars: '&phase=2' },
	 {name:'Del.icio.us',	image: 'AddTo_Delicious.png',	url: 'http://del.icio.us/post?',			urlVar: 'url',	titleVar: 'title',	noteVar: '',	returnVar: '',	otherVars: '' },
	 {name:'Google',		image: 'AddTo_Google.png',		url: 'http://www.google.com/bookmarks/mark?',		urlVar: 'bkmk',	titleVar: 'title',	noteVar: '',	returnVar: '',	otherVars: '&op=edit' },
	 {name:'Windows Live',	image: 'AddTo_Live.png',		url: 'https://favorites.live.com/quickadd.aspx?', urlVar: 'url', titleVar: 'title',	noteVar: '',	returnVar: '',	otherVars: '&marklet=1&mkt=en-us&top=1' },
	 //{name:'Yahoo! MyWeb',	image: 'AddTo_Yahoo.png',		url: 'http://myweb2.search.yahoo.com/myresults/bookmarklet?', urlVar: 'u', titleVar: 't',	noteVar: '', returnVar: '', otherVars: '&d=&ei=UTF-8' },
	 {name:'Technorati',	image: 'AddTo_Technorati.png',	url: 'http://technorati.com/faves?',		urlVar: 'add',	titleVar: '',		noteVar: '',	returnVar: '',	otherVars: '' },
	 {name:'Blink',			image: 'AddTo_Blink.png',		url: 'http://www.blinklist.com/index.php?', urlVar: 'url', titleVar: 'title', noteVar: 'description', returnVar: '', otherVars: '&Action=Blink/addblink.php' },
	 {name:'Facebook',		image: 'AddTo_Facebook.png',	url: 'http://www.facebook.com/sharer.php?', urlVar: 'u', titleVar: 't', noteVar: '', returnVar: '', otherVars: '' },
	 {name:'Furl',			image: 'AddTo_Furl.png',		url: 'http://www.furl.net/storeIt.jsp?',	urlVar: 'u',	titleVar: 't',		noteVar: '',	returnVar: '',	otherVars: '' },
	 {name:'Simpy',			image: 'AddTo_Simpy.png',		url: 'http://simpy.com/simpy/LinkAdd.do?',	urlVar: 'href',	titleVar: 'title',	noteVar: 'note', returnVar: '_doneURI', otherVars: '&v=6&src=bookmarklet' },
	 {name:'Reddit',		image: 'AddTo_Reddit.png',		url: 'http://reddit.com/submit?',			urlVar: 'url',	titleVar: 'title',	noteVar: '',	returnVar: '',	otherVars: '' },
	 {name:'Newsvine',		image: 'AddTo_Newsvine.png',	url: 'http://www.newsvine.com/_wine/save?',	urlVar: 'u',	titleVar: '',		noteVar: '',	returnVar: '',	otherVars: '&popoff=0' },
	 {name:'Stumbleupon',	image: 'AddTo_stumbleupon.png',	url: 'http://www.stumbleupon.com/submit?',	urlVar: 'url',	titleVar: 'title',		noteVar: '',	returnVar: '',	otherVars: '' },
	 {name:'Mr. Wong',		image: 'AddTo_MrWong.png',		url: 'http://www.mister-wong.com/index.php?',urlVar: 'bm_url',	titleVar: 'bm_description',	noteVar: '', returnVar: '', otherVars: '&action=addurl' },
	 {name:'Send as Email',	image: 'envelope.gif',			url: '/script/common/TellFriend.aspx?obtid={0}&obid={1}&',urlVar: '',	titleVar: '',	noteVar: '', returnVar: '', otherVars: '' }
	];

	 this.DrawLink = function(varName, index, cellClass)
	 {
	 	var prompt = (index == (this.sns.length - 1)) ? '' : 'Add this page to ';
	 	var text = "<a class=\"" + cellClass + "\" title=\"" + prompt + this.sns[index].name +
	 				"\" onclick=\"return " + varName + ".addto(" + index.toString() + ");\" " +
					"href=\"#\"><img align=\"absmiddle\" src=\"/images/" + this.sns[index].image +
					"\" width=\"16px\" height=\"16px\" border=\"0\" /> ";
	 	if (this.Showname) text += this.sns[index].name;
	 	return text + "</a> ";
	 };

	this.setupLinks = function (varName, href, title, cols, width, headClass, cellClass) 
	{
		var text = "";
		this.AddTitle = title;
		this.AddURL = href;
		if (cols > this.sns.length) {
			if (this.Horizontal)text += "<span class=\"" + headClass + "\">Add this article to: </span> ";
			for (var i = 0; i < this.sns.length; i++) {
				if (!this.Horizontal) text+="<div>";
				text+=this.DrawLink(varName, i, cellClass)
				text+= (this.Horizontal?" ":"</div>");
			}
		} else {
			text+="<table width=\"" + width.toString() + "\" border=\"0\" cellspacing=\"0\" " +
				  "cellpadding=\"0\"><tr><tr><td colspan=\"" + cols.toString() + "\" class=\"" + 
				  headClass + "\" height=\"20\">Add this article to:</td></tr>\n";
			for (var i = 0; i < this.sns.length; i++) {
				text+="<td valign=\"middle\">";
				text+=this.DrawLink(varName, i, cellClass);
				text+="</td>";
				if ( (((i+1)%cols) == 0) && (i != (this.sns.length-1))) text+="</tr><tr>";
			}
			text+="</td></tr></table>";
		}

		$("#ATD")[0].innerHTML = text; 		
	};

	this.addtoWin = function(addtoFullURL)
	{
		if (!this.popupWin.closed && this.popupWin.location){
			this.popupWin.location.href = addtoFullURL;
			//this.addtoInterval = setInterval("this.closeAddTo();",1000);
		}
		else{
			this.popupWin = window.open(addtoFullURL,'addtoPopUp','width=770px,height=500px,menubar=1,toolbar=1,status=1,location=1,resizable=1,scrollbars=1,left=0,top=100');
			//this.addtoInterval = setInterval("this.closeAddTo();",1000);
			if (!this.popupWin.opener) this.popupWin.opener = self;
		}
		if (window.focus) {this.popupWin.focus()}
		return false;
	};
	
	// closes the popupWin
	this.closeAddTo = function() {
		if (!this.popupWin.closed && this.popupWin.location){
			if (this.popupWin.location.href == this.AddURL)	//if it's the same url as what was bookmarked, close the win
			this.popupWin.close();
		}
		else {	//if it's closed - clear the timer
			clearInterval(this.addtoInterval)
			return true
		}
	};

	this.addto = function(index){
		if (!this.AddURL) this.AddURL = document.location.href;
		if (!this.AddTitle) this.AddTitle = escape(document.title);

		var url = this.sns[index].url.replace("{0}", this.ObjectTypeId.toString());
		url = url.replace("{1}", this.ObjectId.toString());
		var addtoFullURL = url + this.sns[index].urlVar + "=" + this.AddURL + 
			"&" + this.sns[index].titleVar + "=" + this.AddTitle + this.sns[index].otherVars;
		if (this.sns[index].noteVar != "") 
			addtoFullURL = addtoFullURL + "&" + this.sns[index].noteVar + "=" + this.AddTitle;
		if (this.sns[index].returnVar != "")
			addtoFullURL = addtoFullURL + "&" + this.sns[index].returnVar + "=" + this.AddURL;

		switch(this.addtoMethod){
			case 0:	// 0=direct link
				self.location = addtoFullURL
				break
			case 1:	// 1=popup
				this.addtoWin(addtoFullURL);
				break
			default:	
		}
		return false;
	};
	
	this.setupMenu = function() {
		var over = false;
		$(document).ready(function(){
			var e=$("#SBI"), m=$("#ATD");
			var pos = document.all?$(e).position():$(e).offset();
			var eWidth = $(e).outerWidth();
			var mWidth = $(m).outerWidth();
			var eHeight = $(e).outerHeight();
			var left = (pos.left + (eWidth - mWidth)/2) + "px";
			var top = eHeight+pos.top + "px";
			$(m).css({ left: left, top: top });

			$(e).hover(
				function() { $(m).stop(true, true).fadeIn('fast'); }, 
				function() { setTimeout( function() { if (!over) $("#ATD").fadeOut('fast');}, 200); }
			);
			$(m).hover( function() { over=true;}, function() { over=false; $(m).fadeOut('fast');} );
		});
	}
}

//	checking across domains causes errors - this is to suppress these
//function handleError() {return true;}
//window.onerror = handleError;