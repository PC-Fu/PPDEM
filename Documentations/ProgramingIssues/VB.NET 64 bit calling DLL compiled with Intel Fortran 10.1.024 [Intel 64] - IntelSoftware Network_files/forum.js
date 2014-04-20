	function addComment(reply_id){
		$("#comment_box_"+reply_id).show();
		document.getElementById("comment_text_"+reply_id).cols = 60;
	}
	
	function get_reply_file_attachment_id()
	{
		var file_id="";
		$("#file_attach span").each(
			function(index){
				file_id += $(this).attr("id")+",";
		});
		$("#reply_attachment").val(file_id);
	}
	
	function toggle_attachment()
	{
		if($("#hide_attachment").val()==1){
			$("#toggle_attachment").show();		
			$("#show_hide_text").html("<b>"+$("#hide_upload_text").val()+"</b>");
			$("#hide_attachment").val(0);
		}else {
			$("#toggle_attachment").hide();		
			$("#show_hide_text").html("<b>"+$("#show_upload_text").val()+"</b>");
			$("#hide_attachment").val(1);
		}
	}
	
	function frm_topic_reply_add()
	{
		//alert("herererre");return;
		formobj 		= document.frmtopic;
		//min and max character restriction
		var maxchar	 	= formobj.forum_max_char_reply.value;
		var minchar 		= formobj.forum_min_char_reply.value;
		var prefix 		= formobj.forum_auto_prefix_repl.value;	
		
		//text from text area
		//var txtreply 	= formobj.txtreply.value;
		//var txtreply 	= document.getElementById("txtreply").value;
		var txtreply 	= tinyMCE.get('content').getContent();
		var txtreply_wo_html = txtreply.replace(/(<([^>]+)>)/ig,""); 
		var txtreplylen = txtreply_wo_html.length;	
	
		if(txtreplylen >= minchar && txtreplylen <= maxchar)	
		{		
			get_reply_file_attachment_id();
			formobj.method = "post";
			formobj.action = "/"+$("#currlang").val()+"/forums/topic_reply.php";
			/*if($("#topic_moderate_reply").val()=="YES"){
				//if(frm_topic_reply_add_moderate_verify()){
				formobj.submit();		
				//}
			}else{
				//if(frm_topic_reply_add_verify()){
				formobj.submit();		
				//}		
			}*/
			var cur_lang_val 	= $("#currlang").val();
			var ban_check		= $("#block_banned_word").val();
			if(ban_check == 1){
				$.post("/"+cur_lang_val+"/forums/ajax_controller.php?f=frm_reply_check_banned_words&rnd="+Math.random(), {p1:txtreply},
					function(data) {
						if(data == 0) {						
							formobj.submit();
						}
						else{
							$("#banwordserror").show();
							window.scrollTo(0,0);
						}
				 	}
			 	);	
			}
			else{
				formobj.submit();
			}
			
		}
		else
		{
			if(txtreplylen < minchar)
			{
				//alert("Reply text must be minimun of "+minchar+" character");
				form_reply_minchar(minchar);
				formobj.content.focus();			
			}
			else if(txtreplylen > maxchar)
			{
				//alert("Reply text must be maximum of "+maxchar+" character");	
				form_reply_maxchar(maxchar);
				formobj.content.focus();		
			}
		}	
	}
	
	
	function frm_topic_reply_edit()
	{
		formobj 		= document.frmtopic;
		//min and max character restriction
		var maxchar	 	= formobj.forum_max_char_reply.value;
		var minchar 		= formobj.forum_min_char_reply.value;
		var prefix 		= formobj.forum_auto_prefix_repl.value;	
		
		//text from text area
		//var txtreply 	= formobj.txtreply.value;
		//var txtreply 	= document.getElementById("txtreply").value;
		var txtreply 	= tinyMCE.get('content').getContent();
		var txtreply_wo_html = txtreply.replace(/(<([^>]+)>)/ig,""); 
		var txtreplylen = txtreply_wo_html.length;	
		
		var cur_lang_val 	= $("#currlang").val();
		var ban_check		= $("#block_banned_word").val();
	
		if(txtreplylen >= minchar && txtreplylen <= maxchar)	
		{		
			get_reply_file_attachment_id();
			formobj.method = "post";
			formobj.action = "/"+$("#currlang").val()+"/forums/topic_reply_edit.php";
			if($("#topic_moderate_reply").val()=="YES") {
				if(frm_topic_reply_edit_moderate_verify()) {
					if(ban_check == 1){
						$.post("/"+cur_lang_val+"/forums/ajax_controller.php?f=frm_reply_check_banned_words&rnd="+Math.random(), {p1:txtreply},
							function(data) {
								if(data == 0) {
									formobj.submit();
								}
								else{
									$("#banwordserror").show();
									window.scrollTo(0,0);
								}
						 });	
					}
					else{
						formobj.submit();
					}					
				}
			}else{
				if(frm_topic_reply_edit_verify()) {
					if(ban_check == 1){
						$.post("/"+cur_lang_val+"/forums/ajax_controller.php?f=frm_reply_check_banned_words&rnd="+Math.random(), {p1:txtreply},
							function(data) {
								if(data == 0) {
									formobj.submit();
								}
								else{
									$("#banwordserror").show();
									window.scrollTo(0,0);
								}
						 });	
					}
					else{
						formobj.submit();
					}							
				}		
			}
		}
		else
		{
			if(txtreplylen < minchar)
			{
				//alert("Reply text must be minimun of "+minchar+" character");
				form_reply_minchar(minchar);
				formobj.content.focus();			
			}
			else if(txtreplylen > maxchar)
			{
				//alert("Reply text must be maximum of "+maxchar+" character");	
				form_reply_maxchar(maxchar);
				formobj.content.focus();		
			}
		}	
	}
	
	
	function submit_topic()
	{
		formobj = document.create_topic;
		get_topic_file_attachment_id();
		formobj.submit();
		
	}
	
	function get_topic_file_attachment_id()
	{
		/*var file_id="";
		$("#file_attach span").each(
			function(index){
				file_id += $(this).attr("id")+",";
		});
		$("#topic_attachment").val(file_id);*/
		//alert(file_id);
	}
	
	function frm_forum_attach_file(file_attach_id,file_name){
		$("#file_title").val(file_name);
		add_file_attachment(file_attach_id);
		//$("#hdn_file_attachments").val(file_attach_id);
		//$("#file_attach").html($("#file_attach_hidden").html());
	}
	
	function frm_feature_toggle(type)
	{
		if(type == 1){
		$("#feature").show();
		$("#removefeature").hide();
		} 
		else if(type == 2){
		$("#feature").hide();
		$("#removefeature").show();
		}
	}
	
	function frm_topic_reply_delete(reply_id)
	{	
		if(frm_topic_reply_delete_verify()){
			
			$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_topic_reply_delete", { p1:reply_id},
				function(data){
					//alert(data);
				  if(data){
						frm_topic_reply_delete_alert();
						window.location.reload();
					}
				}
			);
		}	
	}
	
	
	function frm_topic_adminoption_save()
	{
		//alert('entery point of function');
		var topic_id				= $("#topic_id").val();
	
		
	
		if ($("#topic_issue_status").length>0){
			var topic_issue_status  	= $("#topic_issue_status").val();
		}else{
			var topic_issue_status  	= "";
		}
		
		if ($("#topic_issue_type").length>0){
			var topic_issue_type		= $("#topic_issue_type").val();
		}else{
			var topic_issue_type		= "";
		}
	
		if ($("#topic_issue_owner_name").length>0){
			var topic_issue_owner_name	= $("#topic_issue_owner_name").val();
		}else{
			var topic_issue_owner_name	= "";
		}
	
		if ($("#topic_issue_owner_id").length>0){
			var topic_issue_owner_id	= $("#topic_issue_owner_id").val();
		}else{
			var topic_issue_owner_id	= "";
		}
		
		if ($("#topic_issue_id").length>0){
			var topic_issue_id	= $("#topic_issue_id").val();
		}else{
			var topic_issue_id	= "";
		}
		
		
		// check for owner name
		if(topic_issue_owner_name != "" && topic_issue_owner_id == ""){
			frm_topic_adminoption_miss('owner');
			return false;
		}
	
		if(topic_issue_owner_name == "" && topic_issue_owner_id == ""){
			topic_issue_owner_id = "null";
		}
		$("#topic_issue_status").length>0
		
		
		var topic_is_featured		= "";
		if ($("#topic_feature_chkbox").length>0){
			if ($("#topic_feature_chkbox").is(":checked")) {
				topic_is_featured = "YES";
			}
			else{
				topic_is_featured = "NO";
			}
		}else{
			topic_is_featured = "";
		}
		
		var topic_is_closed		= "";
		if ($("#topic_openclose_chkbox").length>0){
			if ($("#topic_openclose_chkbox").is(":checked")) {
				topic_is_closed = "CLOSE";
			}
			else{
				topic_is_closed = "OPEN";
			}
		}else{
			topic_is_closed = "";
		}
		
		var topic_is_deleted		= "";
		if ($("#topic_delete_chkbox").length>0){
			if ($("#topic_delete_chkbox").is(":checked")) {
				topic_is_deleted = "INACTIVE";
			}
			else {
				topic_is_deleted = "ACTIVE";
			}
		}else{
			topic_is_deleted = "";
		}
		
		
		//if Type is 'GENERAL' no need to save 'This topic is answered'
		if($("#topic_moderate_chkbox").length>0 && $("#topic_issue_type").length>0 && $("#topic_issue_type").val()==1)
		{
			topic_is_moderated = "";
		}	
		
		
		
		$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_topic_adminoption_save", { p1:topic_id, p2:topic_issue_status, p3:topic_issue_type, p4:topic_issue_owner_id, p5:topic_issue_id, p6:topic_is_featured, p7:topic_is_closed, p8:topic_is_deleted,p9:$("#topic_created_dt").val(),p10:$("#topic_kb_url").val(),p11:$("#topic_component_type_id").val()},
			function(data){  				
				if(data){
					//alert(data);
					frm_topic_adminoption_saved_alert();
					window.location.reload();
				 }
			}
		);
	}
	function frm_forum_topic_delete(topic_id, forum_nice_name)
	{	
		if(frm_forum_topic_delete_verify())
		{
			$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_forum_topic_delete", { p1:topic_id},
				function(data){
					//alert(data);
				  if(data){
						frm_forum_topic_delete_alert();
						window.location = "/"+$("#currlang").val()+"/forums/"+forum_nice_name+"/";
					}
				}
			);
		}	
	}
	
	function frm_forum_display_option_change()
	{
		formobj 		= document.frm_display_option;
		forumid			= formobj.forumbyid.value;
		forum_nice_name 	= formobj.forum_nice_name.value;
		langname		= formobj.language_name.value;
		sortbyval 		= formobj.forumtopicsortyby.value;
		orderbyval 		= formobj.forumtopicorderyby.value;
		filterval 		= formobj.forumtopicfilterby.value;
		var urlformat 	= "/"+langname+"/forums/"+forum_nice_name+"/sort/"+sortbyval+"/ord/"+orderbyval+"/flt/"+filterval+"/";
		//alert(urlformat);
		window.location = urlformat;
	}
	
	function jumpmenu()
	{
		formobj 	= document.frm_display_option;
		selectval = $("#forumjumpmenu").val;
		alert(selectval);
	}
	
	function frm_topic_moderate()
	{	
		if(frm_topic_moderate_verify())
		{
			formobj 	   = document.topic_moderation;
			formobj.method = "post";
			formobj.action = "/"+$("#currlang").val()+"/forums/topic_moderate.php";
			formobj.submit();		
		}	
	}
	
	
	function frm_topic_validation(action_page)
	{		
		formobj 	   			= document.create_topic;
		formobj.method 			= "post";
		formobj.action 			= action_page;	
		var topic_title			= $("#topic_title").val();
		var topic_text 			= tinyMCE.get('content').getContent();
		
		
		topic_forum_id 			= $("#forum_list").find('option').filter(':selected').val();
		formobj.forum_id.value 	= $("#forum_list").find('option').filter(':selected').val();
		if(topic_forum_id == ""){
			frm_topic_miss('topic_forum_name');
			return false;
		}
		
		// check for owner name
		if(topic_title == ""){
			frm_topic_miss('topic_title');
			return false;
		}
		
		
		// check for owner name
		if(topic_text == ""){
			frm_topic_miss('topic_text');
			return false;
		}
	
		//if(frm_topic_edit_verify())
		//{
		get_topic_file_attachment_id();		
		var ban_check		= $("#block_banned_word").val();
		var cur_lang_val 	= $("#currlang").val();
		if(ban_check == 1){
			$.post("/"+cur_lang_val+"/forums/ajax_controller.php?f=frm_topic_check_banned_words&rnd="+Math.random(), {p1:topic_title,p2:topic_text},
				function(data) {
					if(data == 0) {						
						formobj.submit();
					}
					else{
						$("#banwordserror").show();
						window.scrollTo(0,0);
				}
		 	});	
		}
		else {			
			formobj.submit();
		}
			
		
	}	
	
	function frm_topic_cancel(page_url)
	{
		if(frm_topic_cancel_msg()){
			window.location = page_url;	
		}		
	}
	
	function frm_announcements_toggle()
	{
		tabid = document.getElementById("frmannouncement");
		style = document.getElementById("frmannouncement").style.display;
		if(style == ""){
			tabid.style.display = "none";
		}
		else {
			tabid.style.display = "";
		}	
	}
	
	
	function frm_topics_toggle()
	{
		tabid = document.getElementById("frmtopics");
		style = document.getElementById("frmtopics").style.display;
		if(style == ""){
			tabid.style.display = "none";
		}
		else {
			tabid.style.display = "";
		}	
	}
	
	
	function frm_topic_answered(topic_id){
		if(frm_topic_answered_verify() && $("#topic_answered").attr('checked')){
			$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_topic_answered&topic_id=", { p1:topic_id},	
				function(data){	
					//alert(data) 
					if(data) {
						frm_topic_answered_msg('answered');
						window.location.reload();  			
					}else{
						frm_topic_answered_msg('not_answered');
						window.location.reload();
					}
				}
			);
		}else{
			$("#topic_answered").attr('checked',false);
		}
	}
	
	function frm_topic_best_answered(topic_id,reply_id,reply_creator_id){
		//alert($("#topic_best_answer_reply_id").attr('checked'));
		if(frm_topic_best_answered_verify() && $("#topic_best_answer_reply_id_"+reply_id).attr('checked')){
			$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_topic_best_answered&topic_id=", { p1:topic_id, p2:reply_id, p3:reply_creator_id},	
				function(data){				
					if(data) {					
						frm_topic_answered_msg('best_answered');
						window.location.reload();
					}else{
						frm_topic_answered_msg('not_best_answered');
						window.location.reload();
					}
				}
			);
		}else{
			$("#topic_best_answer_reply_id_"+reply_id).attr('checked',false);
		}
	}
	
	
	function frm_topic_filllist(chk_control)
	{	
		formobj 				= document.topic_moderation;
		chk_current_val 		= chk_control.value;
		forum_topic_list_obj	= formobj.forum_topic_list;
		forum_topic_list_val	= formobj.forum_topic_list.value;
		if(chk_control.checked){
			if(forum_topic_list_val == ""){
				forum_topic_list_val = chk_current_val+",";	
			}
			else{
				forum_topic_list_val = forum_topic_list_val+""+chk_current_val+",";
			}		
		}
		else{
			find = chk_current_val+",";
			forum_topic_list_val = forum_topic_list_val.replace(find,"");
		}
		//alert(forum_topic_list_val)
		//forum_topic_list_val = forum_topic_list_val.substr(0,(forum_topic_list_val.length-1));
		forum_topic_list_obj.value = forum_topic_list_val;	
	}
	
	function frm_topic_multiupdate()
	{	
		formobj 			= document.topic_moderation;
		topic_multi_update		= formobj.topic_multi_update.value;
		forum_topic_list_val	= formobj.forum_topic_list.value;
		
		/*value = forum_topic_list_val;
		var tokens = value.split("-");
		new_value = "";
		// parse returned data for non-empty items
		for (var i = 0; i < tokens.length; i++) {
			new_value = $.trim(tokens[i])+",";	
		}*/
		
		if(topic_multi_update==5 || topic_multi_update==6){
			//alert('abc');
			if(topic_multi_update==5){
				// parse returned data for non-empty items
				if(forum_topic_list_val==""){
					frm_select_one_thread();
					return false;
				}
				//window.location = "/"+$("#currlang").val()+"/admin/forums/topic/move/";
				formobj.action = "/"+$("#currlang").val()+"/admin/forums/topic/move/";
				formobj.submit();
			}
			if(topic_multi_update==6){
				var tokens = forum_topic_list_val.split(",");
				new_value = "";
				// parse returned data for non-empty items
				if(forum_topic_list_val==""){
					frm_select_one_thread_merge();
					return false;
				}
				//window.location = "/"+$("#currlang").val()+"/admin/forums/topic/merge/";
				formobj.action = "/"+$("#currlang").val()+"/admin/forums/topic/merge/";
				formobj.submit();
			}
			return 0;
		}else{
			if(forum_topic_list_val == ""){
				frm_topic_multiupdate_restrict_alert();
			}else{
				$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_topic_multiupdate", { p1:topic_multi_update, p2:forum_topic_list_val} ,	
					function(data){	 
						if(data) {
							frm_topic_multiupdate_alert();
							window.location.reload();	  		 		
						}   
					}
				);
			}	
		}
		
		/* Delete the Cookie */
		//Delete_Cookie("thread_chk","/","");
	}
	
	function fill_forum_id()
	{	
		selectedtype = document.getElementById("forum_list").value;
		var current_forum_id = selectedtype;	
		if(current_forum_id==""){
			frm_select_forum_id();
			return false;
		}
		if($("#topic_id").length>0){
			$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_forum_topic_urlbyid_get",{ p1:current_forum_id },
				function(data){
					//alert(data);
					if(frm_topic_change_forum()){
						window.location = data + $("#topic_id").val() + "/";
					}else{
						document.create_topic.forum_list.value = $("#forum_id").val();
					}
				});
		}else{
			if(current_forum_id != ""){
				$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_forum_topic_urlbyid_get",{ p1:current_forum_id },
				function(data){
					window.location = data;
				});
			}
		}
	}
	
	function frm_topic_reply_cancel(page_url)
	{	
		window.location = page_url;
	}
	
	function frm_topic_answered_update()
	{	
		if ($("#topic_is_answered").is(":checked")) {
			$("#topic_is_answered_get").val('YES');
		}
		else{
			$("#topic_is_answered_get").val('NO');
		}
	}
	
	function frm_forum_topic_subscribe(topic_id)
	{	
		subscribeYN = $("#subscribetothistopic").val();
		
		if(subscribeYN=="NO"){
			new_status="YES";	
		}else{
			new_status="NO"
		}
		
		
		if(1){
			$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_forum_topic_subscribe",{ p1:topic_id, p2:new_status },
			function(data){
				frm_topic_subscribe_alert(new_status);
				
				if($("#currpage").val()>1){
					window.location = "/"+$("#currlang").val()+"/forums/"+$("#forum_nice_name").val()+"/topic/"+$("#topic_id").val()+"/page/"+$("#currpage").val()+"/";
				}else{
					window.location = "/"+$("#currlang").val()+"/forums/"+$("#forum_nice_name").val()+"/topic/"+$("#topic_id").val()+"/";	
				}
			});
		}
	}
	
	function frm_topic_role_disable(control)
	{
		cur_val = control.value;
		set		= 0;
		if(control.checked){
			set = 1;		
		}
		
		$("#permissionbox").find("input[@type$='checkbox']").each(function(){
			if(this.value == cur_val && this.name != control.name){			
				if(set == 1){						
					this.checked = false;
					this.disabled = true;
				}
				else{
					this.disabled = false;
				}	
			}
		});	    
	}
	
	function frm_topic_role_disable_onload()
	{	
		get_name 	= $("#special_role_id").val();
		required_name 	= "role"+get_name+"[]";	
		$("#permissionbox").find("input[@type$='checkbox']").each(function(){		
			chk_name = this.name;
			if(chk_name ==required_name){
				frm_topic_role_disable(this);
			}
		}
		);		    
	}
	
	function view_toggle(topic_id)
	{
		if($("#flat_replies").css('display')=="block"){
			// Hide Flat Replies and show thread view
			$("#flat_replies").hide();
			$("#toggle_view").val($("#flat_view").val());
			$("#thread_replies").show();
			$("#thread_view_group").show();
			
			// Set replythreadview 
			$("#reply_thread_view").val(1);
			$("#thread_tree").html("<img src='/media/images/progressbar.gif' border='0'>");
			$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_topic_thread_get",{ p1:topic_id },
			function(data){
				html = data;
				$("#thread_tree").html(html);
			});
		}else{
			// Hide thread view and show flat view
			$("#flat_replies").show();
			$("#toggle_view").val($("#thread_view").val());
			$("#thread_replies").hide();
			$("#thread_view_group").hide();
			
			// Set replythreadview 
			$("#reply_thread_view").val(0);
			
		}
	}
	
	function get_reply_details(reply_id)
	{
		$.get("/"+$("#currlang").val()+"/forums/thread/view/reply/get_reply_details/reply_id/"+reply_id,{ },
		function(data){
			html = data;
			$("#thread_replies").html(html);
			rating_init();
		});
	}
	
	function show_reply_form(reply_id,reply_sq){
		$("#reply_parent_id").val(reply_id);
		if(reply_id>0){
			$("#reply_editor_box_text").html($("#reply_header_text_post").val()+" #"+reply_sq);
		}else{
			$("#reply_editor_box_text").html($("#reply_header_text_topic").val());
		}
	}
	
	function reply_location(reply_id){
		if(reply_id>0){
			window.location = "/"+$("#currlang").val()+"/forums/"+$("#forum_nice_name").val()+"/topic/"+$("#topic_id").val()+"/reply/add/"+reply_id+"/";
		}else{
			window.location = "/"+$("#currlang").val()+"/forums/"+$("#forum_nice_name").val()+"/topic/"+$("#topic_id").val()+"/reply/add/0/";
		}
	}
	
	
	function frm_set_id(id,name){
		$("#set_user_name").val(name);
		$("#set_user_id").val(id);
		adjust_click("adminoption");
	}
	
	function frm_set_id_new(id,name,select_box){
		$("#set_user_name").val(name);
		$("#set_user_id").val(id);
		$("#set_user_select").val(select_box);									
	}
	
	function frm_get_forum(){
		group_id = $("#groupbyid").val();
		if(parseInt(group_id)>0){
			$.getJSON('/forums/ajax_controller.php?f=frm_get_forum_list&p1='+group_id, function(jdata) {
				if (jdata == "") {
					return false;
				}
				if (jdata == null) {
					return false;
				}
				//alert(jdata);
				$("#forumbyid").removeOption(/./);
				
				if(parseInt($("#forum_id").val())>0){
					$("#forumbyid").addOption(0,'');
				}else{
					if($("#forumtopicsortyby").length<=0){
						$("#forumbyid").addOption(0,''+$('#allforum_label').val()+'');
					}
					
				}
				
				selectedIndex = 0;
				
				for (i=0; i<jdata.length; i++) {
					$("#forumbyid").addOption(jdata[i]["forum_id"],''+jdata[i]["forum_title"]+'');
					if(parseInt($("#forum_id").val())>0 && parseInt($("#forum_id").val())==parseInt(jdata[i]["forum_id"])){
						selectedIndex = i+1;
					}
				}
				document.frm_display_option.forumbyid.options[selectedIndex].selected=true;
				frm_get_nice_name();
			});
		}else{
			//alert(jdata);
			$("#forumbyid").removeOption(/./);
			if(parseInt($("#forum_id").val())>0){
					$("#forumbyid").addOption(0,'');
			}else{
				if($("#forumtopicsortyby").length<=0){
					$("#forumbyid").addOption(0,''+$('#allforum_label').val()+'');
				}
				
			}
			selectedIndex = 0;
			document.frm_display_option.forumbyid.options[selectedIndex].selected=true;
		}
	}
	
	function frm_get_nice_name(){
		forum_id = $("#forumbyid").selectedValues();
		$.get("/forums/ajax_controller.php?f=frm_get_forum_nice_name",{ p1:forum_id },
		function(data){
			$("#forum_nice_name").val(data);
		});
	}
	
	function frm_forum_subscribe(forum_id)
	{	
		$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_forum_subscribe",{ p1:forum_id },
			function(data){
				frm_forum_subscribe_alert(data);
				if($("#currpage").val()>1){
					window.location = "/"+$("#currlang").val()+"/forums/"+$("#forum_nice_name").val()+"/page/"+$("#currpage").val()+"/";
				}else{
					window.location = "/"+$("#currlang").val()+"/forums/"+$("#forum_nice_name").val()+"/";	
				}
				
		});
	}


	function frm_forum_mark_read(forum_id)
	{	
		$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_forum_mark_read",{ p1:forum_id },
			function(data){
				if($("#currpage").val()>1){
					window.location = "/"+$("#currlang").val()+"/forums/"+$("#forum_nice_name").val()+"/page/"+$("#currpage").val()+"/";
				}else{
					window.location = "/"+$("#currlang").val()+"/forums/"+$("#forum_nice_name").val()+"/";	
				}
				
		});
	}
	
	function frm_forum_search_total_records(){
		$("#total_records_div").html("&nbsp;"+$("#tot_records").val());
	}
	
	function frm_forum_jump_print(){
		document.printview.submit();
	}
	
	function frm_show_printable_version(){
		
		$("#body").width("100%");
		$("#isnheader").hide();
		$("#header").hide();
		$("#HAT-globalheader").hide();
		$("#HAT-subheader").hide();
		$("#right").hide();
		$("#adminoption").hide();
		$("#displayoption").hide();
		$("#topic-top-bar").hide();
		$("#forumstat").hide();
		$("#footer").hide();
		$("#move_post_bottom_link").hide();
	}
	
	function frm_show_user_list(){
		if($("#topic_is_private").val()=="YES"){
			$("#user_invite_list").show();
			adjust_click("poststuff");
		}else{
			$("#user_invite_list").hide();
		}
	}
	
	function hideQuote(){
		
		if($("#content_ifr").contents().find('#quote_reply').length==1){
			if($("#show_quote").attr("checked")){
				$("#content_ifr").contents().find('#quote_reply').html(quote_text);
			}else{
				//$("#content_ifr").contents().find('#quote_reply').hide();
				quote_text = $("#content_ifr").contents().find('#quote_reply').html();
				$("#content_ifr").contents().find('#quote_reply').html('');
			}
		}else{
			if(!$("#show_quote").attr('checked')){
				html_suffix = $("#content_ifr").contents().find('#tinymce').html();
				$("#content_ifr").contents().find('#tinymce').html('<div><div id="quote_reply">'+quote_text+'</div></div>'+html_suffix);
				//clearcontent();
				$("#show_quote").attr('checked',true);
			}
		}
	}
	
	function clearcontent(){
		$("#content_ifr").contents().find("#quote_reply").contents().find("#quote_reply").html('');
		$("#content_ifr").contents().find("#quote_reply").contents().find("#quote_reply").height('0');
		quote_text = $("#content_ifr").contents().find('#quote_reply').html();
	}
	
	function frm_get_first_post_reply(reply_id,topic_id){
		$.get("/forums/ajax_controller.php?f=frm_get_first_post_reply",{ p1:reply_id,p2:topic_id },
			function(data){
				window.location = "/"+$("#currlang").val()+"/forums/"+$("#forum_nice_name").val()+"/topic/"+topic_id+"/page/"+data+"/#"+reply_id;
		});
	}
	
	
	// this fixes an issue with the old method, ambiguous values 
	// with this test document.cookie.indexOf( name + "=" );
	
	// To use, simple do: Get_Cookie('cookie_name'); 
	// replace cookie_name with the real cookie name, '' are required
	function Get_Cookie( check_name ) {
		// first we'll split this cookie up into name/value pairs
		// note: document.cookie only returns name=value, not the other components
		var a_all_cookies = document.cookie.split( ';' );
		var a_temp_cookie = '';
		var cookie_name = '';
		var cookie_value = '';
		var b_cookie_found = false; // set boolean t/f default f
		
		for ( i = 0; i < a_all_cookies.length; i++ )
		{
			// now we'll split apart each name=value pair
			a_temp_cookie = a_all_cookies[i].split( '=' );
			
			
			// and trim left/right whitespace while we're at it
			cookie_name = a_temp_cookie[0].replace(/^\s+|\s+$/g, '');
		
			// if the extracted name matches passed check_name
			if ( cookie_name == check_name )
			{
				b_cookie_found = true;
				// we need to handle case where cookie has no value but exists (no = sign, that is):
				if ( a_temp_cookie.length > 1 )
				{
					cookie_value = unescape( a_temp_cookie[1].replace(/^\s+|\s+$/g, '') );
				}
				// note that in cases where cookie is initialized but no value, null is returned
				return cookie_value;
				break;
			}
			a_temp_cookie = null;
			cookie_name = '';
		}
		if ( !b_cookie_found ) 
		{
			return null;
		}
	}
	
	/*
	only the first 2 parameters are required, the cookie name, the cookie
	value. Cookie time is in milliseconds, so the below expires will make the 
	number you pass in the Set_Cookie function call the number of days the cookie
	lasts, if you want it to be hours or minutes, just get rid of 24 and 60.
	
	Generally you don't need to worry about domain, path or secure for most applications
	so unless you need that, leave those parameters blank in the function call.
	*/
	function Set_Cookie( name, value, expires, path, domain, secure ) {
		// set time, it's in milliseconds
		var today = new Date();
		today.setTime( today.getTime() );
		// if the expires variable is set, make the correct expires time, the
		// current script below will set it for x number of days, to make it
		// for hours, delete * 24, for minutes, delete * 60 * 24
		if ( expires )
		{
			expires = expires * 1000 * 60 * 60 * 24;
		}
		//alert( 'today ' + today.toGMTString() );// this is for testing purpose only
		var expires_date = new Date( today.getTime() + (expires) );
		//alert('expires ' + expires_date.toGMTString());// this is for testing purposes only
	
		document.cookie = name + "=" +escape( value ) +
			( ( expires ) ? ";expires=" + expires_date.toGMTString() : "" ) + //expires.toGMTString()
			( ( path ) ? ";path=" + path : "" ) + 
			( ( domain ) ? ";domain=" + domain : "" ) +
			( ( secure ) ? ";secure" : "" );
		//console.log("Set Cookie :: %s = '%s'", name, value);
	}
	
	// this deletes the cookie when called
	function Delete_Cookie( name, path, domain ) {
		if ( Get_Cookie( name ) ) document.cookie = name + "=" +
				( ( path ) ? ";path=" + path : "") +
				( ( domain ) ? ";domain=" + domain : "" ) +
				";expires=Thu, 01-Jan-1970 00:00:01 GMT";
		//console.log("Delete Cookie :: %s", name);
	}
	
	// Function called to set/get cookie
	function setcheckbox(id,sub_module){
		if(sub_module=="thread"){
			//value = Get_Cookie("thread_chk");
			value = $("#thread_chk").val();
			if(value){
				if ($("#"+id).is(":checked")) {
					value = value + "," + $("#"+id).val();
				}else{
					var tokens = value.split("-");
					new_value = "";
					// parse returned data for non-empty items
					for (var i = 0; i < tokens.length; i++) {
						if($.trim(tokens[i])==$("#"+id).val()){
							continue;
						}else{
							if(new_value){
								new_value = new_value + "," + $.trim(tokens[i]);							}else{
								new_value = $.trim(tokens[i]);	
							}								
						}
					}
					value = new_value;				
				}
				//Delete_Cookie("thread_chk","/","");
				//Set_Cookie( "thread_chk", value, '', "/", "", "" );
				$("#thread_chk").val(value);
			}else{
				value = "";
				if ($("#"+id).is(":checked")) {
					if(value){
						value = value + "," + $("#"+id).val();	
					}else{
						value = $("#"+id).val();
					}
					
				}
				$("#thread_chk").val(value);
			}				
		}
		
		if(sub_module=="post"){
			//value = Get_Cookie("post_chk");
			value = $("#post_chk").val();
			if(value){
				if ($("#"+id).is(":checked")) {
					value = value + "," + $("#"+id).val();
				}else{
					var tokens = value.split("-");
					new_value = "";
					// parse returned data for non-empty items
					for (var i = 0; i < tokens.length; i++) {
						if($.trim(tokens[i])==$("#"+id).val()){
							continue;
						}else{
							if(new_value){
								new_value = new_value + "," + $.trim(tokens[i]);							}else{
								new_value = $.trim(tokens[i]);	
							}								
						}
					}
					value = new_value;				
				}
				//Delete_Cookie("post_chk","/","");
				//Set_Cookie( "post_chk", value, '', "/", "", "" );
				$("#post_chk").val(value);
			}else{
				value = "";
				if ($("#"+id).is(":checked")) {
					if(value){
						value = value + "," + $("#"+id).val();	
					}else{
						value = $("#"+id).val();
					}
					
				}
				$("#post_chk").val(value);
			}				
		}
	}
	
	function frm_post_move(){
		formobj 			= document.topic_moderation;
		if(formobj.post_chk.value==""){
			frm_select_one_post();
			return false;
		}else{
			formobj.submit();
		}
	}
	
	
	function frm_topic_reply_abuse(reply_id){
		if(frm_topic_reply_abuse_verify()){
			
			$.get("/"+$("#currlang").val()+"/forums/ajax_controller.php?f=frm_topic_reply_abuse", { p1:reply_id},
				function(data){
					//alert(data);
				  if(data){
						frm_topic_reply_abuse_alert();
						window.location.reload();
					}
				}
			);
		}
		
	}
	
	function frm_component_set_cookie(){
		value = Get_Cookie("topic_component_type");
		//alert(value);
		if(value){
			Delete_Cookie("topic_component_type","/","");	
		}
		if($("#topic_component_type").val()){
			Set_Cookie( "topic_component_type", $("#topic_component_type").val(), '', "/", "", "" );
		}
		
	}