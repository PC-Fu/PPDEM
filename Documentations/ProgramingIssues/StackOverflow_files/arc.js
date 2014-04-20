/*
Options:
ARC.noFirstRow();  
*/

function AlternateRowColors() {
  this.allTables = [];
  this.arcTables = [];
  this.firstRow = true;
  this.old_onload = window.onload;
  window.onload = this.init;
  window.arcReference = this;
};

AlternateRowColors.prototype.noFirstRow = ARC_noFirstRow;
AlternateRowColors.prototype.init = ARC_init;

function ARC_init() {
  if(!document.getElementsByTagName) { return; };
  var ARC = window.arcReference;
  ARC.thisType = "";
  ARC.allTables = document.getElementsByTagName("table");
  for(var i=0; i<ARC.allTables.length; i++) {
    if(ARC.allTables[i].className.toLowerCase().substring(0,11) == "tableformat") {
      ARC.arcTables = ARC.arcTables.concat(ARC.allTables[i]);
      ARC.thisType = ARC.allTables[i].className.toLowerCase();
    }
  }
  if(ARC.arcTables.length < 1) { return; };
  for(var jab=0; jab<ARC.arcTables.length; jab++) {
    var table = ARC.arcTables[jab];
    if(ARC.firstRow) {
      table.rows[0].className = ARC.thisType + "FirstRow";
      for(colCount=0; colCount<table.rows[0].cells.length-1; colCount++) {
         table.rows[0].cells[colCount].className = ARC.thisType + "FirstRowCol";
      }
    };
    var rowCount;
    (ARC.firstRow) ? (rowCount = 1) : (rowCount = 0);
    for(rowCount; rowCount<table.rows.length; rowCount++) {
      var tableRow = table.rows[rowCount];
      (rowCount%2 == 0) ? (tableRow.className = ARC.thisType + "RowEven") : (tableRow.className = ARC.thisType + "RowOdd");
      for(colCount=0; colCount<tableRow.cells.length; colCount++) {
         var tableCol = tableRow.cells[colCount];
         tableCol.className = ARC.thisType + "Col";
      }
    }
  }
};

function ARC_noFirstRow() { this.firstRow = false; };

var ARC = new AlternateRowColors();