# MediaTekDocuments

Ce projet est une évolution du projet d'origine disponible à l'adresse :

[https://github.com/CNED-SLAM/MediaTekDocuments](https://github.com/CNED-SLAM/MediaTekDocuments)

Le README du dépôt d'origine présente l'application initiale.

## Fonctionnalités ajoutées

Dans le cadre de l'atelier de professionnalisation, les évolutions suivantes ont été apportées à l'application :

- **gestion des commandes** — création, consultation, modification du suivi et suppression des commandes de livres, de DVD et d'abonnements aux revues ;
- **gestion des exemplaires** — consultation, modification de l'état et suppression des exemplaires de livres et de DVD, ainsi que réception des parutions de revues ;
- **gestion des abonnements** — enregistrement et suivi des abonnements aux revues depuis l'onglet dédié ;
- **alertes sur les abonnements proches de l'expiration** — affichage automatique, à la connexion, des abonnements arrivant à échéance dans les 30 jours ;
- **amélioration de l'interface** — fenêtre de connexion, gestion des droits utilisateur, formulaires d'ajout de documents et organisation des onglets selon les profils ;
- **sécurisation des échanges avec l'API** — authentification Basic, activation de TLS 1.2, validation du certificat serveur et journalisation des erreurs avec Serilog ;
- **création d'un installeur MSI** — projet de déploiement Visual Studio Installer pour la distribution de l'application ;
- **déploiement sur une API distante** — connexion à l'API REST hébergée sur `https://mediatekdocuments.myartsonline.com/`.

## Technologies utilisées

- C#
- WinForms
- .NET Framework
- API REST
- JSON
- MSTest
- Serilog

## Installation

### Développement

1. Ouvrir la solution `MediaTekDocuments.sln` dans Visual Studio.
2. Restaurer les packages NuGet (menu **Gestionnaire de packages NuGet** ou restauration automatique à l'ouverture).
3. Compiler la solution en configuration **Debug** ou **Release**.
4. Lancer le projet **MediaTekDocuments** (F5) pour démarrer l'application.

L'adresse de l'API distante et les identifiants de connexion sont configurés dans le fichier `MediaTekDocuments/App.config`.

### Installeur MSI

L'installeur peut être généré à partir du projet **MediaTekDocumentsSetup** inclus dans la solution. Le script `MediaTekDocumentsSetup/BuildReleaseInstaller.cmd` compile le projet Setup en Release, ajoute les raccourcis Bureau et Menu Démarrer, puis copie les livrables.

**Utilisation de l'installeur :**

1. Lancer `setup.exe` (recommandé) ou ouvrir directement le fichier MSI.
2. Suivre les étapes de l'assistant d'installation.
3. Démarrer l'application depuis le raccourci créé sur le Bureau ou dans le menu Démarrer.

**Emplacement des fichiers :**

| Élément | Chemin |
| --- | --- |
| Fichier MSI (build) | `MediaTekDocumentsSetup/Release/MediaTekDocumentsSetup.msi` |
| Fichier MSI (livrables) | `livrables/MediaTekDocumentsSetup.msi` |
| `setup.exe` (build) | `MediaTekDocumentsSetup/Release/setup.exe` |
| `setup.exe` (livrables) | `livrables/setup.exe` |
| Documentation technique | `docs/csharp/Help/` |
| Tests unitaires | `MediaTekDocumentsTests/` |

## Utilisation

### Connexion

Au lancement, l'application affiche une fenêtre de connexion. Saisir le login et le mot de passe, puis valider. En cas d'identifiants incorrects, un message d'erreur est affiché. L'accès aux fonctionnalités dépend des droits associés au compte (documents, commandes, exemplaires).

### Onglets de l'application

Après authentification, la fenêtre principale propose plusieurs onglets. Seuls ceux correspondant aux droits de l'utilisateur connecté sont visibles :

- **Livres**, **DVD**, **Revues** — consultation et gestion des documents ;
- **Commandes Livres**, **Commandes DVD**, **Commandes Revues** — gestion des commandes ;
- **Parutions des revues** — réception des nouvelles parutions.

### Gestion des commandes

Les onglets **Commandes Livres**, **Commandes DVD** et **Commandes Revues** permettent de rechercher un document par son numéro, de consulter l'historique des commandes associées et d'enregistrer de nouvelles commandes (date, montant, nombre d'exemplaires pour les livres et DVD, date de fin d'abonnement pour les revues). Il est également possible de modifier le suivi d'une commande ou de la supprimer.

### Gestion des exemplaires

Dans les onglets **Livres** et **DVD**, la section **Exemplaires** affiche la liste des exemplaires du document sélectionné. L'utilisateur peut modifier l'état d'usure d'un exemplaire ou le supprimer. L'onglet **Parutions des revues** permet de réceptionner une nouvelle parution en renseignant son numéro, sa date et éventuellement sa photo.

### Gestion des abonnements

L'onglet **Commandes Revues** regroupe la gestion des abonnements aux revues. Après sélection d'une revue, l'historique des commandes et abonnements s'affiche. Une nouvelle commande peut inclure une date de fin d'abonnement. À l'ouverture de l'application, une alerte liste les abonnements dont la date de fin est proche (moins de 30 jours).

## Documentation technique

La documentation de l'application a été générée avec **SandCastle Help File Builder**. Elle est disponible dans le dépôt, dans le dossier `docs/csharp/Help/`. Ouvrir le fichier `docs/csharp/Help/index.html` dans un navigateur pour consulter la documentation des classes et des méthodes du projet.

## Auteur

Bulent KURT – BTS SIO SLAM
