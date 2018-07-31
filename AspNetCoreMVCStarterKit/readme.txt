
je créé une page Accordion en sachant que JQuery n'a aucune chance de fonctionner ici mais on va regarder pourquoi ...

___Date : 31/07/2018 Tout comme le AspNetMVCStarterKit mais avec .NET Core ...

Ajout d'un menu
*****************************************
*** 30-Oct-2017 - Comment ça marche ? ***
*****************************************
1- Ajouter un menu dans la barre 
.\Views\Shared\_Layout.cshtml
<li title="Donner de l'info à l'utilisateur une sorte d'aide">@Html.ActionLink("Link TEXT", "Action Name", "Controler Name")</li>
2- Ajouter un répertoire pour les pages et une page
par exemple :
.\Views\Page
	[@] MaPage.cshtml
3- Ajouter un controler
	MaPageControler.cs


