
	/*	do manage action on article depending on manage option selected	*/
	function art_manage() {

		manage = $('#selmanage').val(); // get manage action value

		if (manage == "protect") { //-- protect article

			$.post(base_url_ajax+"articles/manage_article.php?f=getpermissionbox&rnd="+Math.random(),{
				carticleid:$("#articleid").val()
			},
			function(data) {

				// print permission box
				data = data.replace(/^\s+|\s+$/g,"");

				$('#managediv_title').html('<b>'+ART_MANAGE_PROTECT_TITLE+'</b>');
				html = '<div>';
				html += data;
				html += '</div>';
				$('#managediv_body').html(html);
				$('#btn_manage_save').show();
				$('#btn_manage_close').show();
				$('#managediv').show();

				$('#manage_action').val(1);

				// check for rights
				role_ed("",0);

				role_ed("",1);
			 });
		}
		else if (manage == "flag") { //-- flag on article
			$('#managediv_title').html('<b>'+ART_MANAGE_FLAG_TITLE+'</b>');

			html = '<div style="margin-top:5px;">' + ART_MANAGE_FLAG_TYPE + ': '+$("#flag_type_display").html()+'</div>';
			html += '<div style="margin-top:5px; margin-bottom:5px;"><textarea cols="85" rows="5" id="flagcomments"></textarea></div>';
			$('#managediv_body').html(html);
			$('#btn_manage_save').show();
			$('#btn_manage_close').show();
			$('#managediv').show();

			$('#manage_action').val(2);
		}
		else if (manage == "move") { //-- change article category
			$.post(base_url_ajax+"articles/manage_article.php?f=getcategorybox&rnd="+Math.random(),{
				carticle_category_ids:$("#article_category_ids").val(),
				carticle_type_ids:$("#article_type_ids").val()
			},
			function(data) { // print category box
				data = data.replace(/^\s+|\s+$/g,"");

				$('#managediv_title').html('<b>'+ART_MANAGE_MOVE_TITLE+'</b>');
				html = data;
				$('#managediv_body').html(html);
				$('#btn_manage_save').show();
				$('#btn_manage_close').show();
				$('#managediv').show();
				checkcategory();
				checktype();
				$('#manage_action').val(3);
			 });
		}
		else if(manage == "edit") { // edit article
			article_ref_id = $("#articlerefid").val();
			//window.open(base_url_ajax+"admin/articles/edit/"+article_ref_id+"/0");
			if(typeof(document.new_article)=="undefined"){
				window.open(base_url_ajax+"admin/articles/edit/"+article_ref_id+"/0");
			}
			else {
				var f1 = document.new_article;
				f1.action = base_url_ajax+"admin/articles/edit/"+article_ref_id+"/0";
				f1.target = "_Blank";
				f1.method = "POST";
				f1.submit();
			}
		}
		else if(manage == "history") { // view history
			article_ref_id = $("#articlerefid").val()

			window.location = base_url_ajax+"articles/history/"+article_ref_id+"/0/1";
		}
		else if(manage == "cversion") { // change verions
			article_ref_id = $("#articlerefid").val()

			window.location = base_url_ajax+"articles/history/"+article_ref_id;
		}
		else {
			$('#managediv').html('');
	        $('#managediv').hide();
		}
	}

	// perform manage action
	function art_manage_action() {
		action = $('#manage_action').val();
		switch(action) {
			case 1:
			case "1":
				art_protect_action(); // change permissions
				break;
			case 2:
			case "2":
				art_manage_flag_action(); // flag on article
				break;
			case 3:
			case "3":
				art_manage_move_action(); // change category
				break;
		}
	}

	// submit the form to save new permissions
	function art_protect_action() {
		// ajax post
		$('#frmProtect').submit();
	}

	// ajax post-submit callback
	// data			- post back result data
	// statusText	- status of ajax post
	function art_ajax_poxt_response(data, statusText) {

		data = data.replace(/^\s+|\s+$/g,"");

		html = '<div style="padding:5px;">';
		if(data == "error") {
			html += "<center>"+ART_MANAGE_PROTECT_ERROR+"</center>";
		}
		else {
			html += "<center>"+ART_MANAGE_PROTECT_SUCCESS+"</center>";
		}
		html += "</div>";
		$('#managediv_body').html(html);
		$('#btn_manage_save').hide();
		$('#btn_manage_close').hide();
	}

	// cancel the manage option
	function manage_discard() {
		$('#managediv').hide();
	}

	// set the flag for article
	function art_manage_flag_action() {
		$.post(base_url_ajax+"articles/manage_article.php?f=setarticleflag&rnd="+Math.random(),{
			cflagid:$('#selflag').val(),
			cflagcomments:$('#flagcomments').val(),
			carticleid:$("#articleid").val()
		},
		function(data) {
			data = data.replace(/^\s+|\s+$/g,"");
			html = '<div style="padding:5px;">';
			html += "<center>"+data+"</center>";
			html += "</div>";
			$('#managediv_body').html(html);
			$('#btn_manage_save').hide();
			$('#btn_manage_close').hide();
		 });
	}

	// save changed article categories
	function art_manage_move_action() {
		$.post(base_url_ajax+"articles/manage_article.php?f=movecategory&rnd="+Math.random(),{
			carticle_category_ids:$("#hdn_category_sel").val(),
			carticle_type_ids:$("#sel_type").val(),
			carticleid:$("#articleid").val()
		},
		function(data) {
			data = data.replace(/^\s+|\s+$/g,"");

			if(data != "error") {
				newids = $("#hdn_category_sel").val();
				obj = document.getElementById("article_category_ids");
				if(obj) {
					obj.value = newids;
				}

				newids = $("#sel_type").val();
				obj = document.getElementById("article_type_ids");
				if(obj) {
					obj.value = newids;
				}
			}
			html = '<div style="padding:5px;">';
			if(data == "error") {
				html += "<center>"+ART_MANAGE_MOVE_ERROR+"</center>";
			}
			else {
				html += "<center>"+ART_MANAGE_MOVE_SUCCESS+"</center>";
			}

			html += "</div>";
			$('#managediv_body').html(html);
			$('#btn_manage_save').hide();
			$('#btn_manage_close').hide();
		 });
	}

	// set the version to publish
	// art_id		- article id to make published
	// art_ref_id	- article ref id to make current publish verions inactive
	// view_flag	- to mantain change varion column show on history page
	function art_activate(art_id,art_ref_id,view_flag) {

		// confirm message
		var agree = confirm(ART_ASK_ACTIVATE);

		if (agree) {
			$.post(base_url_ajax+"articles/manage_article.php?f=activate&rnd="+Math.random(),{
				carticleid: art_id,
				carticlerefid: art_ref_id
			},
			function(data) {
				data = data.replace(/^\s+|\s+$/g,"");
				if(data == "error") {
					alert(ART_MANAGE_CHANGE_VERSION);
				}
				else {
					window.location.href = base_url_ajax+"articles/history/"+art_ref_id+"/"+view_flag+"/1";
				}
			 });
		}
	}