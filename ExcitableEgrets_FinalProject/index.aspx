<!---
# Name: Excitable Egrets
# email: carfornc@mail.uc.edu, phanpv@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/2024
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project uses asp.net to solves problems from LeetCode to show understanding of asp.net web forms and classes. 
# Citations: ChatGPT (chatgpt.com), LeetCode (leetcode.com), Gemini (gemini.google.com)
# Anything else that's relevant:
--->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ExcitableEgrets_FinalProject.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lbSelectPrompt" runat="server" Text="Label">Select a LeetCode Problem to view.</asp:Label>
            <br />

            <asp:DropDownList ID="ddlProblems" runat="server">
                <asp:ListItem>Problem 233</asp:ListItem>
                <asp:ListItem>Problem 466</asp:ListItem>
                <asp:ListItem>Problem 135</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="btnViewProblem" runat="server" Text="View Problem" OnClick="btnViewProblem_Click" />
            <br />
            <asp:TextBox ID="tbProblemDesription" runat="server" Height="44px" Width="929px" TextMode="MultiLine" Wrap="true"></asp:TextBox>
            <br />
            <asp:Label ID="lbSolution" runat="server" Text="The solution is:"></asp:Label>
            <asp:TextBox ID="tbSolutionValue" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
