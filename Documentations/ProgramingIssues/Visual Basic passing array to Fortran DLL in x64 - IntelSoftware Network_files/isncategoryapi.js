$(document).ready(function(){
           dp.SyntaxHighlighter.ClipboardSwf = '/media/images/clipboard.swf';
           dp.SyntaxHighlighter.HighlightAll('code');	
	   show_cat('isn_category');
	   checkcategory();
	   checktype();
                });
                function checkcategory(){
                        var sel_cat_list = "";
                        $("input[@type='checkbox']").each(function(){
				if($(this).attr("checked")){
					if($(this).attr("category_id")){
						sel_cat_list += $(this).attr("category_id") + "|";	
					}
				}
                        });
                        sel_cat_list = sel_cat_list.substr(0,sel_cat_list.length-1);
                        $('#hdn_category_sel').val(sel_cat_list);
                }
                function checktype(){
                        var sel_type_list = "";
                        $("input[@type='checkbox']").each(function(){
				if($(this).attr("checked")){
					if($(this).attr("type_id")){
						sel_type_list += $(this).attr("type_id") + "|";	
					}
				}
                        });
                        sel_type_list = sel_type_list.substr(0,sel_type_list.length-1);
                        $('#sel_type').val(sel_type_list);
                }
		var p_id = "all_category";
                function show_cat(id){
			$('#sp_'+p_id).hide();
			$('#'+p_id).show();
			$('#sp_'+id).show();
			$('#'+id).hide();
			$('.all_category').hide();
                        $('.'+id).show();
			p_id = id;
			//show_type(id);
                }
		function show_type(){
			alert("dasdsa");	
		}
function removetag(id){    
	$('#'+id).remove();
	$('#rm_'+id).remove();
	gettags();
}
var nt_id = 0;
function addtag(tag_text_id){
        nt_id += 1;
        var tag_title = $('#'+tag_text_id).val();        
	if(!check_tag(tag_title)){
		var html = "";
        	html += "<span id='new_tag_"+nt_id+"' class='tagclass'>"+tag_title+"</a></span>&nbsp;";
	        html +="<span id='rm_new_tag_"+nt_id+"'><a href=javascript:removetag('new_tag_"+nt_id+"') >[X]</a></span>&nbsp;";
        	$('#tag_list').append(html);
	        $('#'+tag_text_id).val(""); 
		gettags();
	}
	else{
		alert(ERROR_TAG_EXISTS);
	}
}
function gettags(){   
        var html = "";
        $('.tagclass').each(function(){    
	     html += $(this).html() + ",";         
        });  
        $('#hdn_tags_set').val(html);
}
function check_tag(tag){
	var tag_array =  $('#hdn_tags_set').val();
	tag_array = tag_array.split(',');
	for(var i=0;i<tag_array.length;i++){
		if(tag_array[i] == tag){
			return true;
		}
	}
	return false;
}
function getuser(input_id,hdn_id){
	$('#'+input_id).val("");
	var new_id = -1;
	$('.ac_over').each(function(){
		new_id = $(this).attr("id");		
	});
	if(!check_user(new_id,hdn_id)){
		$('#'+hdn_id).val($('#'+hdn_id).val()+new_id+",");
		$.get("/services/showuser/"+new_id,function(data){
			$('#user_list').append("<div style='float:left;padding:3px' id='user_"+new_id+"'><span><strong><a href=javascript:removeuser('user_"+new_id+"','"+hdn_id+"') >[X]</a></strong></span>"+data+"</div>");
		});
	}
	else{
		alert(ERROR_AUTHOR_EXISTS);
	}
}
function removeuser(id,hdn_id){
	var user_id = id.split('user_');
	$('#'+id).remove();
	var existing_users = $('#'+hdn_id).val();
        existing_users = existing_users.split(',');
	var new_list = "";
        for(var i=0;i<existing_users.length;i++){
                if((existing_users[i] != "") && (existing_users[i] != user_id[1])){
                	new_list += existing_users[i] + ",";
                }
        } 
	$('#'+hdn_id).val(new_list);
}
function check_user(id,hdn_id){
	var existing_users = $('#'+hdn_id).val();
	existing_users = existing_users.split(',');
	for(var i=0;i<existing_users.length;i++){
		if(existing_users[i] == id){
			return true;
		}
	}
	return false;
}
