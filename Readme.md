Test Technique de LemonWay :

1 - Web Service:
Un web service asmx qui contient 2 webmethods decimal Fibonacci(int n) qui prend comme parametre un entier entre 1 et 100, et retourne -1
ailleurs et XmlToJson(string xml) qui convertit une chaine xml valide à un json, sinon il retourne "Bad xml Format" si la chaine
est invalide.
note : pour la methode Fibonacci, j'ai utilisé le type decimal au lieu de int car à partir de la 47ème itération, la methode n'est plus
dans le type int.

2 - Client:
- Un client application console pour consommer le web service et ses deux fonctions Fibonacci et XmlToJson.
- Un client WinForms pour consommer le même web service de manière asynchrone avec utilisation de Thread et un modal pour le chargement.

3 - Test:
Un projet test unitaire pour tester les différents cas et les différentes méthodes présentes dans tous les projets.

4 - Log :
J'ai bien loggé les differents instructions et les différents cas d'échec (exceptions) dans des fichers.

5 - Publication de la solution sur Github:
La solution est bie publié sur Github.
