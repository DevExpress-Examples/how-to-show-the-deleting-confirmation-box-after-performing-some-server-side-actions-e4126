﻿using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.Data;

public partial class _Default : System.Web.UI.Page {

    protected void gvProducts_Init(object sender, EventArgs e) {
        ASPxGridView gridView = sender as ASPxGridView;
        gridView.JSProperties["cpShowDeleteConfirmBox"] = false;
    }

    protected void gvProducts_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e) {
        ASPxGridView gridView = sender as ASPxGridView;
        if (e.ButtonID == "btDelete") {
            
            //Server-side actions performed before showing popup here
                        
            gridView.JSProperties["cpRowIndex"] = e.VisibleIndex;
            gridView.JSProperties["cpShowDeleteConfirmBox"] = true;
        }
    }

    protected void gvProducts_RowDeleting(object sender, ASPxDataDeletingEventArgs e) {

        //Custom row deleting code here
        throw new Exception("Data modifications are not allowed.");

        e.Cancel = true;
    }
}