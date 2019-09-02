﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Libraries.aspx.cs" Inherits="LibraryApplication.Libraries" %>

<%@ Import Namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <asp:Repeater ID="LibrariesRepeater" runat="server" ItemType="DataRow">
        <HeaderTemplate>
            <table>
                <thead>
                    <tr>
                        <th>Branch Name</th>
                        <th>Address</th>
                        <th>&nbsp;</th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Item.Field<string>("Name") %></td>
                <td><%# Item.Field<string>("Address") %></td>
                <td><asp:HyperLink runat="server" 
                    NavigateUrl='<%# $"~/EditLibrary.aspx?ID={Item.Field<int>("Id")}"%>' 
                    Text="Edit" /></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Button ID="AddButton" runat="server" OnCommand="AddButton_Command" Text="Add Library" />
</asp:Content>
