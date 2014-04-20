jQuery(document).ready( function() {
	add_postbox_toggles('page');
	make_slugedit_clickable();

	// close postboxes that should be closed
	jQuery('.if-js-closed').removeClass('if-js-closed').addClass('closed');

	// show things that should be visible, hide what should be hidden
	jQuery('.hide-if-no-js').show();
	jQuery('.hide-if-js').hide();

	//jQuery('#title').blur( function() { if ( (jQuery("#post_ID").val() > 0) || (jQuery("#title").val().length == 0) ) return; autosave(); } );

	// hide advanced slug field
	//jQuery('#pageslugdiv').hide();	
});