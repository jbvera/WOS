﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookCopies.aspx.cs" Inherits="LibraryApplication.BookCopies" %>

<%@ Import Namespace="System.Data" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div>
        <label>Book Title: </label>
        <asp:Label ID="BookTitleLabel" runat="server" />
    </div>
    <div>
        <label>Author: </label>
        <asp:Label ID="AuthorLabel" runat="server" />
    </div>
    <div>
        <label>ISBN: </label>
        <asp:Label ID="IsbnLabel" runat="server" />
    </div>
    <div>
        <asp:Repeater ID="BookCopiesRepeater" runat="server"
            ItemType="DataRow">
            <HeaderTemplate>
                <table>
                    <thead>
                        <tr>
                            <th>Library</th>
                            <th>Available</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label runat="server"
                            Text='<%# Item.Field<string>("LibraryName") %>'
                            Font-Strikeout='<%# !Item.Field<bool>("Available") %>' />
                    </td>
                    <td>
                        <asp:CheckBox runat="server"
                            AutoPostBack="true"
                            Checked='<%# Item.Field<bool>("Available") %>'
                            OnCheckedChanged="Available_CheckedChanged" />
                    </td>
                    <td hidden="hidden">
                        <asp:Label ID="BookCopyId" runat="server" Text='<%# Item.Field<int>("Id") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
