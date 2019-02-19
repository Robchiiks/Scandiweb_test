<?php
session_start();

$SKU = "";
$Name = "";
$Price = "";
$Type = "";


$db = mysqli_connect('localhost', 'root', '', 'add_items');

if (isset($_POST['add'])) {
$SKU = mysql_real_escape_string($_POST['SKU']);
$Name = mysql_real_escape_string($_POST['Name']);
$Price = mysql_real_escape_string($_POST['Price']);
$Type = mysql_real_escape_string($_POST['Type']);

if ($SKU){
if ($SKU['SKU'] === $SKU){
	array_push($errors, "SKU already exists");
}

}
}

$query = "INSERT INTO products (SKU, Name, Price, Type)";
