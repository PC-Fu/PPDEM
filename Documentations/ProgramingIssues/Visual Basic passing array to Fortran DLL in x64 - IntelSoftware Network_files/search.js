//KMP
document.writeln("<style>");
document.writeln("#srchBox {font-family:verdana,sans-serif;font-size:10px;color:#555555;width:220px;}");
document.writeln("#srchBox input {font-size:11px;margin:0px;padding:0px;margin-left:2px;}");
document.writeln("#srchSAL {margin:0px;padding:0px;}");
document.writeln("#srchResults, #srchPager {word-wrap:break-word;font-family:verdana,sans-serif;font-size:10px;color:#555555;}");
document.writeln("#srchResults a {cursor:pointer;color:#0000CC;text-decoration:underline;}");
document.writeln("#srchBaseURL {color:#008000;text-decoration:none;}");
document.writeln("#srchTerm {width:120px;font-size:11px;border:1px solid #BCCDF0;}");
document.writeln("#srchBranding {font-size:11px;padding-top:2px;padding-bottom:5px;border-bottom:1px solid #E9E9E9;text-align:right;}");
document.writeln("#srchExpander {font-size:14px;font-weight:bold;}");
document.writeln("#srchMenu {width:200px;display:none;}");
document.writeln("#srchMenu li:hover {background:white;}");
document.writeln("#srchMenu li {cursor:pointer;margin:0px;padding:5px;}");
document.writeln(".filterHover {display:block;position:absolute;padding:0px;margin:0px;border:1px solid #82A1BC;background:#ECEEED;list-style-image:none;list-style-position:outside;list-style-type:none;font-size:11px;font-family:verdana,sans-serif;color:#555555;}");
document.writeln(".srchMenuHover {background:white;}");
document.writeln(".srchPgr, .srchPgrSel  {color:#000000;font-size:11px;font-weight:bold;cursor:pointer;text-decoration:underline;display:inline;}");
document.writeln(".srchPgrSel {color:#A90A08;text-decoration:none;}");
document.writeln("#searchResultsTime{text-align:right;}");
document.writeln("#searchSortByDateRelevance{text-align:right;}");
document.writeln("#searchSpelling{color:red;}");
document.writeln("</style>");

(function($) {

	var relativepath = "http://mysearch.intel.com/ssf/";
	$.SearchObj = function(options){

		$.SearchObj.init = true;
		
		if (options)
			$.extend($.SearchObj.defaults, options);

		$.SearchObj.sortBy = $.SearchObj.defaults.searchSortBy;

		if ($("#srchBox").length > 0)
		{
			$("#srchBox").append(
				'<div id="srchInput">'
				+ '<form id="srchSAL" onSubmit="return $.SearchObj.searchSAL(true);">'
				+ '<input id="srchTerm" type="text" size="10" autocomplete="off">'
				+ '<input id="srchButton" type="submit" value="Go"></form>'
				+ '<div id="srchBranding">'
				+ '<span id="srchExpander"></span>'
				+ '<span id="srchBrand">powered by <image align="top" src="http://software.intel.com/file/15321"></span> '
				+'</div>'
			);
			
			if ($("#srchResults").length == 0)
			{
				$("#srchBox").append('<div id="srchResults"></div>'
					+'<div id="srchPager"></div>');
			} else
			{
				$("#srchResults").after('<div id="srchPager"></div>');
			}

			$("#srchBrand").html($.SearchObj.defaults.branding);

			$("#srchTerm").width($("#srchInput").width() - ($("#srchButton").width()+10));
			if ($.browser.msie) // fix IE issue with LI element width
				$("#srchMenu li").css({width:"100%"});

			$("#srchButton,#srchMenu").hover(
				function(){
					$("#srchMenu").css("top",$("#srchButton").position().top + $("#srchButton").height() + "px");
					$("#srchMenu").css("left",$("#srchButton").position().left + $("#srchButton").width() + 4 - $("#srchMenu").width() + "px");
					$("#srchMenu").show().addClass("filterHover");
				}
				,function(){
					$("#srchMenu").removeClass("filterHover").hide();
				}
			);

			$("#srchMenu li").hover(
				function(){
					$(this).addClass("srchMenuHover");
				}
				,function(){
					$(this).removeClass("srchMenuHover");
				}
			);
			
			if ($.SearchObj.defaults.filter.length > 0)
			{
				$("#srchMenu li").each(function(i){
					if ( $(this).attr("id") == $.SearchObj.defaults.filter)
					{
						$(this).html('<img id="srchCheckImg" src="' + relativepath + 'checksmall.gif">' + $(this).html());
					}
				});
			}

			$("#srchMenu li").click(function(){
				$("#srchCheckImg").remove();
				$(this).html('<img id="srchCheckImg" src="' + relativepath + 'checksmall.gif">' + $(this).html());
			});

			$("#srchExpander").click(function(){
				if ( $(this).html() == "- ")
					$(this).html("+ ");
				else
					$(this).html("- ");
				$("#srchResults").toggle();
				$("#srchPager").toggle();
			});

			if ( $.SearchObj.defaults.searchStartupQuery.length > 0)
			{
				$("#srchTerm").val($.SearchObj.defaults.searchStartupQuery);
				$.SearchObj.searchSAL(true);
			}
		}
	};

	$.SearchObj.init = false;

	$.SearchObj.defaults = {
			filter:"",
			branding:'powered by <image align="top" src="http://software.intel.com/file/15321">',
			searchPg:1,
			searchTerm:"",
			resultsPerPage:10,
			maxPagesToShow:5,
			searchAPIKey:"",
			searchStartupQuery:"",
			searchSpellingSuggestion:"",
			searchLanguageCode:"lang_en",
			stripBreaks:true,
			searchSortBy:"", /* 1=By Date,Blank or 0=Relevance */
			showResultTime:true,
			showSortByDateRelevance:true,
			trimURI:true
	};
	
	
	function srchFormatter(r){
	
		var baseURL = r.U.replace("http://","");
		var size = "";
		var dateTime = "";
		if ($.SearchObj.defaults.trimURI)
		{
			baseURL = baseURL.split("/")[0];
		}
		if(r.T == null)
			r.T = "";
		if(r.HAS.C && r.HAS.C.SZ)
		{
			size = " - " + r.HAS.C.SZ;
		}
		if(r.FS.VALUE)
		{
			dateTime = " - " + r.FS.VALUE;
		}
		if ( $.SearchObj.defaults.stripBreaks)
		{
			r.S = (r.S == null ? r.T : r.S.replace("<br>",""));
		}
		else
		{
			r.S = (r.S == null ? r.T : r.S);
		}
		
		var mimeType = "";
		switch(r.MIME)
		{
			case "text/plain":
				mimeType = "[TEXT] ";
				break;    
			case "application/rtf":
				mimeType = "[RTF] ";
				break;    
			case "application/pdf":
				mimeType = "[PDF] ";
				break;    
			case "application/postscript":
				mimeType = "[PS] ";
				break;    
			case "application/vnd.ms-powerpoint":
				mimeType = "[MS POWERPOINT] ";
				break;    
			case "application/vnd.ms-excel":
				mimeType = "[MS EXCEL] ";
				break;    
			case "application/msword":
				mimeType = "[MS WORD] ";
				break;    
		}
		
		return ( "<div><a target='_blank' href='" + r.U + "'>" + mimeType  + r.T + "</a><br/>" 
			+ r.S + "<br/><div id='srchBaseURL'>" + baseURL + size + dateTime + "</div><br/></div>");
	};
	
	$.SearchObj.submitSuggestion = function(srcVal){
		$("#srchTerm").val(srcVal);
		$.SearchObj.searchSAL(true);
	};
	
	$.SearchObj.changeSort = function(srcVal){
		$.SearchObj.defaults.searchPg = 1;
		$.SearchObj.sortBy = srcVal ? srcVal:"";
		$.SearchObj.searchSAL(false);
	};
	
	$.SearchObj.searchSAL = function(resetSearchPage){
		$.SearchObj.defaults.searchTerm = $("#srchTerm").val();
		if (resetSearchPage)
		{
			$.SearchObj.defaults.searchPg = 1;
			$.SearchObj.sortBy = $.SearchObj.defaults.searchSortBy;
		}

		var siteSearch = ""; // get the filter if one is selected
		$("#srchMenu li").each(function(){
			if ($(this).find("#srchCheckImg").length > 0)
				siteSearch = $(this).attr("id");
		});

		if ( siteSearch.length > 0)
			$.SearchObj.defaults.searchTerm += (" " + siteSearch);  // space the search terms
		else
			if ($.SearchObj.defaults.filter.length > 0)
				$.SearchObj.defaults.searchTerm += (" " + $.SearchObj.defaults.filter);  

		$("#srchBrand").html($.SearchObj.defaults.branding + '<img src="' + relativepath + 'ajax-loader.gif">');
		
		if ( $.SearchObj.defaults.searchAPIKey.length == 0) 
			alert("searchAPIKey Required")
		else
			$.getScript(relativepath + "ajaxsearch.aspx?F=Search&P1=" + encodeURIComponent($.SearchObj.defaults.searchAPIKey) + "&P2=" + encodeURIComponent($.SearchObj.defaults.searchTerm) + "&P3=" + $.SearchObj.defaults.resultsPerPage + "&P4=" + (($.SearchObj.defaults.searchPg - 1) * $.SearchObj.defaults.resultsPerPage) + "&P5=" + encodeURIComponent($.SearchObj.defaults.searchLanguageCode)+ "&P6=" + encodeURIComponent($.SearchObj.sortBy));

		return false;
	};
	
	$.SearchObj.searchCallback = function (jsonData) {

		//Spelling errors checks - Walczewski
		if ( jsonData.GSP.Spelling)
		{
			$.SearchObj.defaults.searchSpellingSuggestion = jsonData.GSP.Spelling.Suggestion.q;
		}
		
		$("#srchBrand").html($.SearchObj.defaults.branding);

		var showLessThanThisManyPages = $.SearchObj.defaults.maxPagesToShow + 1;
		var rslt = "";
		$("#srchExpander").html("");
		$("#srchPager").html("");
		$("#srchPager").hide();

		//add spelling suggestion
		if ( jsonData.GSP.Spelling)
		{
			rslt += "<div id=\"searchSpelling\">Did you mean: " + "<a href='javascript:$.SearchObj.submitSuggestion(\"" + $.SearchObj.defaults.searchSpellingSuggestion +  "\");'>" + $.SearchObj.defaults.searchSpellingSuggestion + "</a></div><br/>";
		}
		
		if ( $.SearchObj.defaults.showResultTime) 
		{
			rslt += "<div id=\"searchResultsTime\">" + ( !jsonData.GSP.RES ? "0": jsonData.GSP.RES.M) + " search results (" + Math.round(jsonData.GSP.TM*100)/100 + " seconds)</div><br/>";
		}
	
		if ( jsonData.GSP.RES)
		{
			if ( $.SearchObj.defaults.showSortByDateRelevance)
			{
				if ($.SearchObj.sortBy == "1")
				{
					rslt += "<div id=\"searchSortByDateRelevance\">Sort by date / <a href='javascript:$.SearchObj.changeSort();'>Sort by relevance</a></div><br/>";
				}
				else
				{
					rslt += "<div id=\"searchSortByDateRelevance\"><a href='javascript:$.SearchObj.changeSort(1);'>Sort by date</a> / Sort by relevance</div><br/>";
				}
			}

			// Pager "1 2 3 4.."  etc Population
			var breakNextPgr = false;
			for (var s = 1; s <= (jsonData.GSP.RES.M/$.SearchObj.defaults.resultsPerPage) && s < showLessThanThisManyPages; s++)
			{
				if ( $.SearchObj.defaults.searchPg == s || breakNextPgr)
				{
					breakNextPgr = jsonData.GSP.RES.R.length < $.SearchObj.defaults.resultsPerPage;
					$("#srchPager").append("<div class='srchPgrSel'>" + s + "</div>&nbsp;");
				}
				else
					$("#srchPager").append("<div class='srchPgr'>" + s + "</div>&nbsp;");
				if (breakNextPgr)
					break;
			}
			if ( (jsonData.GSP.RES.M/$.SearchObj.defaults.resultsPerPage) > showLessThanThisManyPages)
				$("#srchPager").append("...");
			$("#srchPager div").click(function(){
				if ($(this).hasClass("srchPgr"))
				{
					$.SearchObj.defaults.searchPg = $(this).html();
					$.SearchObj.searchSAL(false);
				}
			});
			// -----------------------------

			$("#srchPager")
			$("#srchExpander").html("- "); // match count
			$("#srchResults").show();
			$("#srchPager").show();

			// special code for non arrary return results for only one search hit
			if (!jsonData.GSP.RES.R.length)
				rslt += srchFormatter(jsonData.GSP.RES.R);
			else
				for ( var s = 0; s < jsonData.GSP.RES.R.length; s++)
				{
					rslt += srchFormatter(jsonData.GSP.RES.R[s]);
				}
		}
		$("#srchResults").html(rslt);
	};

// end of closure
})(jQuery);