﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ToDoList.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <jwl:ToDoList runat="server" NumberOfRecordsToDisplay ="7"/>
            <jwl:ToDoListAdd runat="server" />
        </div>
    </form>
</body>
</html>
