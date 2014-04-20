	var rhc_id = 0; // initial count for new free text RHC
	var pollid = 0; // initial count for new poll RHC

	// to add dynamic rhc
	function art_add_rhc() {
		var html = "";
		if ($('#selrhc').val() == 'freetext') 
			html = getFreeTextTemplate(rhc_id,'','');
		else 
			html = getPollTemplate(rhc_id,'','');
		$('#sortable').append(html);
		rhc_id++;
	}
	
	function getFreeTextTemplate(rhc_id,rhc_element,rhc_elementdesc) {
		var html = '<div class="boxHeader"><div style="float:right;"><a href="#" onclick="$(\'#'+rhc_id+'\').remove(); return false;">X</a></div><div style="float:left;">';
		html += '<input type="text" name="rhc_element'+rhc_id+'" id="rhc_element'+rhc_id+'" value="' + rhc_element + '"></div><div style="clear:both;"></div></div>';
		html += '<div style="padding:5px;">';
		html += '<textarea style="width:600px;height:100px" name="rhc_elementdesc'+rhc_id+'" id="rhc_elementdesc'+rhc_id+'">' + rhc_elementdesc + '</textarea></div>';
		html = ('<li id="' + rhc_id + '"><div class="box">' + html + '</div></li>');
		return html;
	}

	function getPollTemplate(rhc_id,rhc_element) {
		var html = '<div class="boxHeader"><div style="float:right;"><a href="#" onclick="$(\'#'+rhc_id+'\').remove();return false;">X</a></div><div style="float:left;">'+ART_POLL+'</div><div style="clear:both;"></div></div>';
		html += '<div style="padding:5px;"><span class="bodytext">'+ART_POLLID+'</span>: ';
		html += '<input type="text" name="rhc_element'+rhc_id+'" id="rhc_element'+rhc_id+'" style="width:100px" value="' + rhc_element + '"></div>';
		html = ('<li id="' + rhc_id + '"><div class="box">' + html + '</div></li>');
		return html;
	}

	// validate article fields
	// flag	- to distingush validation on publish and save draft. 1-publish, 0-draft
	function art_validate(flag) {
		// create form object
		formobj = document.formArticle;

		/*PUBLISH_IN_FUTURE can not be saved in draft mode*/
		/*if(flag != 1) {
			obj_hdn_article_status 		= formobj.hdn_article_status;
			if(obj_hdn_article_status){
				obj_hdn_article_status_val 	= obj_hdn_article_status.value;
				if(obj_hdn_article_status_val == "PUBLISH_IN_FUTURE") {
					return;
				}
			}
		}*/

		/*PUBLISH_IN_FUTURE can not be saved in draft mode ends here*/

		// article title validation
		if(formobj.txttitle.value == "") {
			alert(ART_TITLE_VAL);
			formobj.txttitle.focus();
			return;
		}

		// nicename validation
		if(formobj.txtnicename) {
			if(!validate_nicename(formobj.txtnicename,1)) {
				return;
			}

			art_unique_nicename_chk(0);

			if($('#hdnnicename_flag').val() == "0") {
				alert(ART_CREATE_ERR_NICENAME);
				formobj.txtnicename.focus();
				return false;
			}
		}

		// category validation - at least one category need to be selected
		if(formobj.hdn_category_sel) {
			if(formobj.hdn_category_sel.value == "") {
				if(!confirm(ART_CATEGORY_SEL)){
					return false;
				}

			}
		}

		// article type validation
		/*if(formobj.sel_type) {
			if(formobj.sel_type.value == 0) {
				alert(ART_TYPE_VAL);
				formobj.sel_type.focus();
				return;
			}
		}*/

		// FAQ validation - if article is FAQ need to select FAQ from drop down
		if(formobj.isfaq) {
			if(formobj.isfaq[0].checked) {

				if(formobj.faqid.value == "") {
					alert(ART_FAQ_MSG1);
					//formobj.faqid.focus();
					return;
				}
				else {
					myRegxp = /^[\d]+$/;  // regular expression for alpha numeric

					if(!(myRegxp.test(formobj.faqid.value))) {
						alert(ART_FAQ_MSG2);
						//formobj.faqid.focus();
						return;
					}
				}
			}
		}

		// action for - save is clicked
		document.formArticle.hdn_action.value = "1";

		// re-sort and re-number the RHC elements so they are submitted in the proper order.
		var result = $('#sortable').sortable('toArray');
		var sortedResult = new Array();
		$.each(result, function(i,e){
			if ( $("#"+result[i]+":has('textarea')").length > 0) {
				sortedResult[i] = getFreeTextTemplate(i,$('#rhc_element'+e).val(),$('#rhc_elementdesc'+e).val());
			} else {
				sortedResult[i] = getPollTemplate(i,$('#rhc_element'+e).val());
			}
		});
		$("#sortable").html("");
		$.each(sortedResult,function(i,e){
		  $("#sortable").append(e);
		});

		if(flag != 1) {
			document.formArticle.submit();
		}
		else {
			return true;
		}
	}

	// validation on publishing article
	function art_publish(future_publish) {

		if(art_validate(1)) {

			// validate publish dates
			if(document.formArticle.hdn_is_editor.value == 1 || document.formArticle.hdn_is_admin.value == 1) {

				var dt = document.formArticle.fromdate

				if(dt.value == "") {
					alert(ART_PUBLISH_START);
					//dt.focus();
			        return;
				}

				// validate date range
				if(validate_date_range(document.formArticle.fromdate,"",1) > 1) {
			        tmpobj 	= new Date();
			        month	= (parseInt(tmpobj.getMonth()) +1);
			        day		= parseInt(tmpobj.getDate());

			        if(month<10) {
			        	month = "0" + month;
			        }
			        if(day<10) {
			        	day = "0" + day;
			        }
					date2 = month + "/" + day + "/" +  tmpobj.getFullYear();

					document.formArticle.fromdate.value = date2; // set current date

			        //return;
				}

				var RegExPattern = /^(?=\d)(?:(?:(?:(?:(?:0?[13578]|1[02])(\/|-|\.)31)\1|(?:(?:0?[1,3-9]|1[0-2])(\/|-|\.)(?:29|30)\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})|(?:0?2(\/|-|\.)29\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))|(?:(?:0?[1-9])|(?:1[0-2]))(\/|-|\.)(?:0?[1-9]|1\d|2[0-8])\4(?:(?:1[6-9]|[2-9]\d)?\d{2}))($|\ (?=\d)))?(((0?[1-9]|1[012])(:[0-5]\d){0,2}(\ [AP]M))|([01]\d|2[0-3])(:[0-5]\d){1,2})?$/;

				var dt = document.formArticle.enddate;

				if(dt.value != "") {
				    if ((dt.value.match(RegExPattern)) && (dt.value!='')) {
				        //alert('Date is OK');
				    }
				    else {
				        alert(DATE_ERROR_MESSAGE);
				        //dt.focus();
				        return;
				    }
				}

				if(document.formArticle.enddate.value != "") {
					if(validate_date_range(document.formArticle.enddate,"",1) > 1) {
						alert(DATE_ERROR_MESSAGE3);
				        document.formArticle.enddate.focus();
				        return;
					}

					if(validate_date_range(document.formArticle.fromdate,document.formArticle.enddate,1) == 0) {
						alert(DATE_ERROR_MESSAGE4);
				        document.formArticle.fromdate.focus();
				        return;
					}
				}
			}

			document.formArticle.hdn_action.value = "2";

			document.formArticle.submit();

		}
		else {
			return;
		}
	}

	// enable / disable faq
	function art_faq_ed() {
		formobj = document.formArticle;

		if(formobj.isfaq) {
			if(formobj.isfaq[0].checked) {
				formobj.faqid.disabled = false;
				formobj.article_template_id.disabled = false;
			}
			else if(formobj.isfaq[1].checked) {
				formobj.faqid.disabled = true;
				formobj.article_template_id.disabled = true;
				formobj.isfaq[1].value = "";
			}
		}
	}

	// close submit article screen
	function art_window_close() {
		//flag = confirm("You are about to go out of this page. Continue?");
		//if(flag) {
		if($("#article_return_page").length>0){
			window.location = base_url+$("#article_return_page").val();
		}else{
			window.location = base_url_ajax+"admin/articles/list_articles.php?page=1";
		}
		//}
	}

	// validitoin on page load
	function art_onload_activity() {

		$('#sel_type').val($('#article_type').val());

		// enable / diable faq
		art_faq_ed();

		$("#loading").hide();

		if(document.formArticle.hdn_is_editor.value == 1 || document.formArticle.hdn_is_admin.value == 1) {
			// check for rights
			role_ed("",0);

			role_ed("",1);
		}
	}

	// enable/disable roles permission rows
	// obj			- current selected control (checkbox form role permission checkbox list)
	// right_index	- check box index in role array
	function role_ed(obj,right_index) {
		formobj = document.formArticle;

		if(!formobj) { // for artcile protection
			formobj = document.frmProtect;
		}

		roles = $('#role_id_list').val();

		arr_role = roles.split('#');

		if(obj=="") {
			obj = document.getElementById('7_'+right_index);
		}

		if(obj.id == "7_" + right_index) {
			for(i=1;i<arr_role.length;i++) {
				tmpobj = document.getElementById(arr_role[i]+'_'+right_index);//formobj.elements[arr_role[i]+"[]"][right_index];
				if(obj.checked) {
					tmpobj.disabled = true;
					tmpobj.checked	= false;
				}
				else {
					tmpobj.disabled = false;
				}
			}
		}
	}

	// check for unique nice name - makes ajax call
	// flag - to diftingush whether to make hidden ajax call (no message display), or display message (on check nicename avaliablity)
	function art_unique_nicename_chk(flag) {

		formobj = document.formArticle;

		if(flag == 1) { // validating nicename
			if(!validate_nicename(formobj.txtnicename,2)) {
				return;
			}
		}

		// if changed nicename is diffrent from old one
		if($('#txtnicename').val() != $('#hdnoldnicename').val()) {
			if(flag == 1) {
				$("#loading_nicename").show();
				$("#nicenamemessage").html("");
			}
			$.post(base_url_ajax+"admin/articles/ajax_controller.php?f=nicenamecheck&rnd="+Math.random(), {
				cnicename:$('#txtnicename').val(),
				crefid:$('#hdn_ref_article_id').val()
			},
			function(data) {
				if(data.indexOf("#error#") != -1) {
					if(flag == 1) {
						$("#loading_nicename").hide();
						$("#nicenamemessage").html(ART_CREATE_ERR_NICENAME);
					}
					$('#hdnnicename_flag').val(0)
				}
				else if(data.indexOf("#success#") != -1) {
					if(flag == 1) {
						$("#loading_nicename").hide();
						$("#nicenamemessage").html(ART_CREATE_SUC_NICENAME);
					}
					$('#hdnnicename_flag').val(1)
				}
			 });
		}
		else {
			if(flag == 1) {
				$("#nicenamemessage").html(ART_CREATE_SUC_NICENAME);
			}
		}
	}

	// validating nicename for special characters
	// obj_nicename		- nicename field name
	// flag				- flag to alert error or not
	function validate_nicename(obj_nicename,flag) {
		if(obj_nicename.value == "") {

			if(flag == 1) {
				alert(ART_NICENAME_VAL);
			}
			else if(flag == 2) {
				$("#nicenamemessage").html(ART_NICENAME_VAL);
			}
			obj_nicename.focus();
			return false;
		}
		else {
			myRegxp = /^[A-Z\a-z\d\-\_]+$/;  // regular expression for alpha numeric
			if(!(myRegxp.test(obj_nicename.value))) {
				if(flag == 1) {
					alert(ART_NICENAME_VAL_RES1);
				}
				else if(flag == 2) {
					$("#nicenamemessage").html(ART_NICENAME_VAL_RES1);
				}
				obj_nicename.focus();
				return false;
			}

			/*myRegxp = /^[\d]+$/;  // regular expression for alpha numeric

			if((myRegxp.test(obj_nicename.value))) {
				if(flag == 1) {
					alert(ART_NICENAME_VAL_RES2);
				}
				else if(flag == 2) {
					$("#nicenamemessage").html(ART_NICENAME_VAL_RES2);
				}
				obj_nicename.focus();
				return false;
			}*/
		}

		return true;
	}


	// validate date range
	// objdate1 		- from date value
	// objdate2			- to date value
	// format			- date format
	function validate_date_range(objdate1,objdate2,format) {
		date1 = objdate1.value;
		if(objdate2 == "") {
			tmpobj = new Date();
			date2 = (parseInt(tmpobj.getMonth()) +1) + "/" +  tmpobj.getDate() + "/" +  tmpobj.getFullYear();
		}
		else {
			date2 = objdate2.value;
		}

		switch(format) {
			case 1: // mm/dd/yyyy
			case "1":
				ndate1	= new Date(date1);
				ndate2	= new Date(date2);
				break;
			case 2: // dd/mm/yyyy
			case "2":
				ndate1	= new Date(swapDayMonth(date1));
				ndate2	= new Date(swapDayMonth(date2));
				break;
			default: // mm/dd/yyyy
				ndate1	= new Date(date1);
				ndate2	= new Date(date2);
		}

		diff = ndate2 - ndate1;

		if(diff<0) {
			return 0;
		}
		else if(diff == 0) {
			return 1;
		}
		else if(diff > 0) {
			return 2;
		}
	}

	// format date for comparison
	// dateVal	- date value
	function swapDayMonth(dateVal) {
	    firstIndex = dateVal.indexOf("/");
	    dd = dateVal.substring(0, firstIndex);
	    secondIndex = dateVal.indexOf("/", (firstIndex+1));
	    mm = dateVal.substring((firstIndex+1), secondIndex);
	    yy = dateVal.substring((secondIndex+1));
	    return (mm+"/"+dd+"/"+yy);
	}

	// to suggest nicename based on article title
	function art_generate_nicename() {

		formobj = document.formArticle;

		if($('#hdn_ref_article_id').val() == "" && $('#txttitle').val() != "") {

			// if changed nicename is diffrent from old one
			$("#loading_nicename").show();
			$("#nicenamemessage").html(ART_SUGGESTING_NN);

			$.post(base_url_ajax+"admin/articles/ajax_controller.php?f=nicenamesuggest&rnd="+Math.random(), {
				cnicename:$('#txttitle').val(),
				crefid:$('#hdn_ref_article_id').val()
			},
			function(data) {
				tmpresults = data.split("#");
				if(tmpresults[0] == "error") {
					$("#nicenamemessage").html(ART_SUGGETED_NN_NOT_AVAL_MSG);
					$('#hdnnicename_flag').val(0)
				}
				else {
					$("#nicenamemessage").html(ART_SUGGETED_NN_AVAL_MSG);
					$('#hdnnicename_flag').val(1)
				}

				if(tmpresults[1] == "") {
					$("#nicenamemessage").html(ART_SUGGETED_NN_NO_SUGESTIONS);
				}

				$('#txtnicename').val(tmpresults[1]);
				$('#hdnoldnicename').val(tmpresults[2]);

				$("#loading_nicename").hide();

			 });
		}
	}


	function art_template_id(default_value, selected_value){

		template_type = $("#faqid").val();
		$.getJSON('/admin/articles/ajax_controller.php?f=art_template_get_id&p1='+template_type, function(jdata) {

			/*if (jdata == "") {
				return false;
			}*/
			$("#article_template_id").removeOption(/./);
			$("#article_template_id").addOption('',''+default_value+'');
			if (!( jdata == null || jdata == "" )) {
				selected_index = 0;
				for (i=0; i<jdata.length; i++) {
					$("#article_template_id").addOption(jdata[i]["template_id"],''+jdata[i]["template_title"]+'');
					if(parseInt(selected_value)==parseInt(jdata[i]["template_id"])){
						selected_index = i+1;
					}
				}
				document.formArticle.article_template_id.options[selected_index].selected=true;
			}
			//frm_get_nice_name();
		});

	}

	function art_select_pre_template(){
		pre_template_id = $("#art_pre_template_id").val();
		$.get('/admin/articles/ajax_controller.php?f=art_pre_template_data&p1='+pre_template_id, function(data) {
			if (data == "") {
				return false;
			}
			if($("#content_ifr").contents().find('#art_pre_template').html()==null){
				data = $("#content_ifr").contents().find('#tinymce').html() + "<br><div id='art_pre_template'>" +data+ "</div>";
				$("#content_ifr").contents().find('#tinymce').html(data);
			}else{
				$("#content_ifr").contents().find('#art_pre_template').html('');
				$("#content_ifr").contents().find('#art_pre_template').html(data);
				//data = $("#content_ifr").contents().find('#tinymce').html() + data;
				//$("#content_ifr").contents().find('#art_pre_template').html(data1);
			}
		});
	}