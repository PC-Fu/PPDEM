function add_postbox_toggles(page) {
	jQuery('.postbox h3').prepend('<a class="togbox">+</a>&nbsp;&nbsp;');
	jQuery('.postbox h3').click( function() { jQuery(jQuery(this).parent().get(0)).toggleClass('closed'); save_postboxes_state(page); adjust_click("poststuff"); } );
	
}

function save_postboxes_state(page) {
	var closed = jQuery('.postbox').filter('.closed').map(function() { return this.id; }).get().join(',');
	jQuery.post(postboxL10n.requestFile, {
		action: 'closed-postboxes',
		closed: closed,
		closedpostboxesnonce: jQuery('#closedpostboxesnonce').val(),
		page: page
	});
}

function adjust_click(div_name){
	$("#"+div_name+" input").each(
		function(index){
			//alert($(this).attr("id"));
			if($("#set_user_name").length>0){
				ele_name = $("#set_user_name").val();
				if($(this).attr("id")==ele_name){
					var offset = $("#"+ele_name).offset();
					//$("#txtinvite").suggest();
					$("#"+ele_name+"_result").css({
						top: (offset.top + document.getElementById(ele_name).offsetHeight) + 'px',
						left: offset.left + 'px'
					});
				}
			}
	});	
}

/*function adminoption_click(){
	$("#adminoption input").each(
		function(index){
			//alert($(this).attr("id"));
			ele_name = $("#set_user_name").val();
			if($(this).attr("id")==ele_name){
				var offset = $("#"+ele_name).offset();
				//$("#txtinvite").suggest();
				$("#"+ele_name+"_result").css({
					top: (offset.top + document.getElementById(ele_name).offsetHeight) + 'px',
					left: offset.left + 'px'
				});
			}
	});
}*/