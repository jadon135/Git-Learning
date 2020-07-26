<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/UserControl/Site.Master" CodeFile="Create.aspx.cs"  Inherits="WebApplication1.Config.Role.Create" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">

            <!-- Page Heading -->
           
          
            <div class="col-lg-12 ">
                
                <div class="col-lg-9 " >
                    <div class="card shadow mb-4">
                        <!-- Card Header - Dropdown -->
                        <div class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                            <h6 class="m-0 font-weight-bold text-primary">ADD ROLE</h6>

                        </div>
                        <!-- Card Body -->
                        <div class="card-body">

                            <div class="col-lg-12">
                                <input type="text" id="txtName" runat="server" class="form-control" placeholder="Enter Role" />

                            </div>
                            <br />


                            <div class="col-lg-12">
                               
                                <select class="form-control">
                                    <option>-Select Status-</option>
                                    <option>Active</option>
                                    <option>Deactive</option>
                                </select>

                                <br />
                                <div class="col-lg-12">
                                    <asp:Button ID="btnSavae" runat="server" Text="Save"  CssClass="btn btn-info" />
                                    <input type="button" value="Cancel" class=" btn btn-secondary" />
                                </div>
                            </div>


                            <!-- Collapsable Card Example -->


                        </div>

                    </div>
                </div>
            </div>
 </div>

    

</asp:Content>