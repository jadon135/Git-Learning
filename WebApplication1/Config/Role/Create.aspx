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
                                <asp:TextBox ID="txtName" class="form-control" placeholder="Enter Role" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="error" ControlToValidate="txtName" runat="server" ErrorMessage="please enter role name !!"></asp:RequiredFieldValidator>

                            </div>
                            <br />


                            <div class="col-lg-12">
                               
                                <%--<select class="form-control" id="ddlStatus" runat="server" >
                                    <option value="-Select Status-" >-Select Status-</option>
                                    <option value="1" >Active</option>
                                    <option value="0">Deactive</option>
                                </select>--%>
                                <asp:DropDownList ID="ddlStatus" CssClass="form-control" runat="server">
                                    <asp:ListItem Value="-Select Status-">-Select Status-</asp:ListItem>
                                    <asp:ListItem Value="1">Active</asp:ListItem>
                                    <asp:ListItem Value="0">Deactive</asp:ListItem>
                                </asp:DropDownList>


                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2"  CssClass="error" ControlToValidate="ddlStatus" InitialValue="-Select Status-" runat="server" ErrorMessage="please select valid status !! "></asp:RequiredFieldValidator>
                                <br />
                                <div class="col-lg-12">
                                 
                                    <asp:Button ID="btnSave" runat="server" CssClass="btn btn-info" OnClick="btnSave_Click" Text="Save" />

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