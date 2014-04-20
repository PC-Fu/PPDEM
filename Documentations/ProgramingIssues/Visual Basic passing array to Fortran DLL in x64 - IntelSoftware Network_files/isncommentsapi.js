var max_id = 0;
var max_count = 0;
function hide_comment_box(id){
	$('#comment_box_'+id).hide('slow');
}
function submitcomment(id,show)
{
	var module_id = "";
	if($("#hdn_module_"+id).val() == ""){
		alert(ERROR_COMMENT_DOWN);
		return false;
	}
	var source_id = "";
	if($("#hdn_source_"+id).val() == "")
	{
		alert(ERROR_COMMENT_DOWN);
		return false;
	}
	var language_id = "";
	if($("#hdn_language_"+id).val() == "")
	{
		alert(ERROR_COMMENT_DOWN);
		return false;
	}
	if($("#comment_text_"+id).val() == "")
	{
		alert(ERROR_COMMENT_NO_TEXT);
		return false;
	}
	if($("#comment_author_name_"+id).val() == "")
	{
		alert(ERROR_COMMENT_AUTHOR_NAME);
		return false;
	}
	if($("#comment_author_email_"+id).val() == "")
	{
		alert(ERROR_COMMENT_AUTHOR_EMAIL);
		return false;
	}
	$.post("/services/setcomment/rnd="+Math.random(),
				{cmid:$("#hdn_module_"+id).val(),
				 csid:$("#hdn_source_"+id).val(),
				 clid:$("#hdn_language_"+id).val(),
				 cauthor_name:$("#comment_author_name_"+id).val(),
				 cauthor_email:$("#comment_author_email_"+id).val(),
				 cauthor_url:$("#comment_author_url_"+id).val(),
				 ctext:$("#comment_text_"+id).val(),
				 paid:$("#hdn_post_author_"+$("#hdn_source_"+id).val()).val(),
				 curl:document.location.protocol + "//" + document.location.host + document.location.pathname
				 },function(data){
					$('#comment_error_'+id).show().html(data).fadeOut(8000);
					clear_comment(id);
					getcomments($("#hdn_module_"+id).val(),$("#hdn_source_"+id).val(),$("#hdn_language_"+id).val());
   				    }
				 );
}
function getcomments(module_id,source_id,language_id){
     	$.post("/services/getcomments/rnd="+Math.random(),
				{cmid:module_id,
				 csid:source_id,
				 clid:language_id,
				 paid:$('#hdn_post_author_'+source_id).val(),
				 cmaxid:max_id
				 },function(data){
					if(data != ""){
						$('#comment_html_'+source_id).append(data);
// IE has issues here. max_count comes back as 0. doesn't seem to be able to dynamically re-read the javascript
						$('#comment_max_count').html(max_count);
					}
   				    }
				 );
}
function clear_comment(id) {
	$("#comment_text_"+id).val("");
	$("#secure_code_"+id).val("");
	$("#comment_image_"+id).attr("src","");
	$("#comment_image_"+id).attr("src","/services/captcha/index.php?width=200&height=60&characters=5&app=comment&rnd="+Math.random());
}
