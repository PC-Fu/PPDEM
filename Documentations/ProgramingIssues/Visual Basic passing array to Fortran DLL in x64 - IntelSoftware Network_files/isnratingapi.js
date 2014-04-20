	$(document).ready(function(){
		rating_init();
	});
	function rating_init(){
		$('input[@type=radio].star').rating({
			callback:function(value){
				var source_id = $(this).attr("name").split("r_r_");
				post_rating($('#hdn_module_'+source_id[1]).val(),source_id[1],$('#hdn_language_'+source_id[1]).val(),$('#hdn_author_'+source_id[1]).val(),value);
			}
		});
	}
	function post_rating(module_id,source_id,language_id,author_id,value){
		$("#r_s_"+source_id).html(RATING_LOADING);
		$.post("/services/dorating/rnd="+Math.random(),
		{module_id:module_id,source_id:source_id,language_id:language_id,rating:value,author_id:author_id},function(data){
			show_rating(module_id,source_id,language_id,data);
		});
	}
	function show_rating(module_id,source_id,language_id,rating_data){
		 $.post("/services/displayrating/rnd="+Math.random(),
                        {module_id:module_id,source_id:source_id,language_id:language_id},
			function(data){
                        	$("#r_s_"+source_id).html(data);
                        	rating_init();
				alert(rating_data);
	                });
	}
