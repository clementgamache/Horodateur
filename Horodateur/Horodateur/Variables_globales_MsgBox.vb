Public Module Variables_globales_MsgBox
    'Erreurs

    'Mots de passe
    Public ERREURMAUVAISMOTDEPASSE As String = "Erreur : Mot de passe invalide"
    Public ERREURMOTDEPASSEPRESENTINVALIDE As String = "Erreur : Mot de passe présent invalide"
    Public ERREURNOUVEAUMOTDEPASSENONCONFORME As String = "Erreur : Nouveau mot de passe non conforme :" + vbNewLine + "Entre 5 et 20 caractères requis"
    Public ERREURNOUVEAUMOTDEPASSEMALREECRIT As String = "ERREUR : Nouveau mot de passe mal réécrit"

    'Identifiant
    Public ERREURIDINEXISTANT As String = "Erreur : Identifiant inexistant"
    Public ERREURIDDEJAPRIS As String = "Erreur : Identifiant déjà pris"
    Public ERREURID3CHIFFRES As String = "Erreur : Identifiant non conforme :" + vbNewLine + "3 chiffres requis"
    Public ERREURID2CHIFFRES As String = "Erreur : Identifiant non conforme : " + vbNewLine + "Deux chiffres requis"
    'Sélection
    Public ERREURAUCUNELEMENTSELECTIONNE As String = "Erreur : Aucun élément de la liste sélectionné"

    'Modification
    Public ERREURAUCUNEMODIFICATION As String = "Erreur : Aucune modification apportée à l'élément original"
    Public ERREURMODIFICATIONPARDEFAUT As String = "Erreur : Interdiction de modifier la valeur par défaut"
    Public ERREURDATEAPRESMAINTENANT As String = "Erreur : Temps de transaction après le moment présent"
    'Suppression
    Public ERREURSUPPRESSIONPARDEFAUT As String = "Erreur : Interdiction de supprimer la valeur par défaut"

    'Chronologie
    Public ERREURSORTIEAVANTENTREE As String = "Erreur : Sortie établie avant l'entrée"
    Public ERREURDATEFINAVANTDATEDEBUT As String = "Erreur : Date finale établie avant la date initiale"
    Public ERREURENTREEAVANTSORTIEPRECEDENTE As String = "Erreur : Entrée établie avant la sortie précédente"
    Public ERREURSORTIEAPRESENTREESUIVANTE As String = "Erreur : Sortie établie après l'entrée suivante"
    Public ERREURFORMATDEDATE As String = "Erreur : Mauvais format de date"
    Public ERREURISOLEMENTDEDATE As String = "Erreur : Transaction existante entre les deux dates sélectionnées"
    'Employé
    Public ERREURAUCUNEMPLOYECORRESPONDANT As String = "Erreur : Aucun employé correspondant à la recherche"

    'Département
    Public ERREURDEPARTEMENTEXISTANT As String = "Erreur : Département déjà existant"
    Public ERREURDEPARTEMENTDEMAUVAISELONGUEUR As String = "Erreur : Département non conforme :" + vbNewLine + "Entre 1 et 30 caractères requis"
    Public ERREURDEPARTEMENTENCOREUTILISE As String = "Erreur : Département toujours utilisé par au moins un employé"

    'Type
    Public ERREURTYPEDEMAUVAISELONGUEUR As String = "Erreur : Type non conforme :" + vbNewLine + "Entre 1 et 30 caractères requis"
    Public ERREURTYPEENCOREUTILISE As String = "Erreur : Type toujours utilisé par au moins un employé"

    'Nom et prénom
    Public ERREURNOMNONCONFORME As String = "Erreur : Nom inscrit non conforme :" + vbNewLine + "Entre 1 et 30 caractères requis"
    Public ERREURPRENOMNONCONFORME As String = "Erreur : Prénom inscrit non conforme :" + vbNewLine + "Entre 1 et 30 caractères requis"

    'Demande de confirmation
    Public DEMANDEDECONFIRMATION As String = "Êtes-vous sûr ?" + vbNewLine + "Cet élément sera perdu à jamais"
    Public DEMANDEDECONFIRMATIONTITRE As String = "Demande de confirmation"

    'Confirmation
    Public CONFIRMATIONMODIFICATION As String = "Modification réussie"
    Public CONFIRMATIONSUPPRESSION As String = "Suppression réussie"
    Public CONFIRMATIONINSERTION As String = "Insertion réussie"
End Module
