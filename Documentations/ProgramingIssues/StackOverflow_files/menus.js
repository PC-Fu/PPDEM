<!--
var count = 0;
var catCount = 0;
var menuData = new Array();
var tmpData = new Array();

// Products
tmpData[count++] = new menuobject("Processors","http://www.intel.com/products/processor/index.htm?iid=CorporateV3+Header_2_Product_Proc");
tmpData[count++] = new menuobject("Chipsets","http://www.intel.com/products/chipsets/index.htm?iid=CorporateV3+Header_2_Product_Chip");
tmpData[count++] = new menuobject("Motherboards","http://www.intel.com/products/motherboard/index.htm?iid=CorporateV3+Header_2_Product_MB");
tmpData[count++] = new menuobject("Desktop","http://www.intel.com/products/desktop/index.htm?iid=CorporateV3+Header_2_Product_Desk");
tmpData[count++] = new menuobject("Notebook","http://www.intel.com/products/laptop/index.htm?iid=CorporateV3+Header_2_Product_Lap");
tmpData[count++] = new menuobject("Server/Workstation","http://www.intel.com/products/server/index.htm?iid=CorporateV3+Header_2_Product_SvrWkn");
tmpData[count++] = new menuobject("Embedded","http://www.intel.com/design/embedded/index.htm?iid=CorporateV3+Header_2_Product_Embed");
tmpData[count++] = new menuobject("Networking &amp; Communications","http://www.intel.com/netcomms/index.htm?iid=CorporateV3+Header_2_Product_NetComm");
tmpData[count++] = new menuobject("Software","http://www.intel.com/cd/software/main/asmo-na/eng/294191.htm?iid=CorporateV3+Header_2_Product_SW");
tmpData[count++] = new menuobject("More Products","http://www.intel.com/products/sitemap.htm?iid=CorporateV3+Header_2_Product_Sitemap");

renderdata();

// Technology & Research
tmpData[count++] = new menuobject("Architecture","http://www.intel.com/technology/architecture-silicon/index.htm?iid=CorporateV3+Header_2_Technology_Architecture");
tmpData[count++] = new menuobject("Platform Benefits","http://www.intel.com/platforms/index.htm?iid=CorporateV3+Header_2_Technology_Platform");
tmpData[count++] = new menuobject("Research","http://www.intel.com/research/index.htm?iid=CorporateV3+Header_2_Technology_Research");
tmpData[count++] = new menuobject("Silicon","http://www.intel.com/technology/silicon/index.htm?iid=CorporateV3+Header_2_Technology_Silicon");
tmpData[count++] = new menuobject("Software &amp; Applications","http://www.intel.com/technology/applications/index.htm?iid=CorporateV3+Header_2_Technology_SWApps");
tmpData[count++] = new menuobject("Standards &amp; Initiatives","http://www.intel.com/standards/index.htm?iid=CorporateV3+Header_2_Technology_Standards");

renderdata();

// Resource Center
tmpData[count++] = new menuobject("Personal Computing","http://www.intel.com/personal/index.htm?iid=CorporateV3+Header_2_Resource_Personal");
tmpData[count++] = new menuobject("Business/Enterprise","http://www.intel.com/business/index.htm?iid=CorporateV3+Header_2_Resource_Business");
tmpData[count++] = new menuobject("Hardware Design","http://www.intel.com/design/index.htm?iid=CorporateV3+Header_2_Resource_HardwareDesign");
tmpData[count++] = new menuobject("Software Network","http://www.intel.com/cd/ids/developer/asmo-na/eng/index.htm?iid=CorporateV3+Header_2_Resource_Software");
tmpData[count++] = new menuobject("Reseller Center","http://www.intel.com/cd/channel/reseller/asmo-na/eng/index.htm?iid=CorporateV3+Header_2_Resource_Reseller");

renderdata();

// Supports & Downloads
tmpData[count++] = new menuobject("Download Center","http://downloadfinder.intel.com/scripts-df-external/Support_Intel.aspx?iid=CorporateV3+Header_2_Support_Download");
tmpData[count++] = new menuobject("Product Support","http://www.intel.com/support/product.htm?iid=CorporateV3+Header_2_Support_Product");
tmpData[count++] = new menuobject("Support Services","http://www.intel.com/services/index.htm?iid=CorporateV3+Header_2_Support_Support");
tmpData[count++] = new menuobject("Contact Support","http://www.intel.com/support/feedback.htm?iid=CorporateV3+Header_2_Support_Contact");
tmpData[count++] = new menuobject("Search Support","http://mysearch.intel.com/support/default.aspx?iid=CorporateV3+Header_2_Support_Search");


renderdata();

//-->