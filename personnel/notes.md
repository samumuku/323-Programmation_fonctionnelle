# Module 323 Prog Fonctionnelle

### Séquence 1 27.08.2025

- var = n'importe quel type
- au lieu d'une valeur, on fait **Function**
- fonction d'ordre supérieur => fonction où on peut mettre une fonction comme paramètre
- ACTION(void)
  exemple

```c#
void FSuperior(Action< int > x)
{
    x(1)
}
```

- Action (définir la méthode), < type > type de méthode et le nom suit.
- Func < int, int, double >
- Le dernier type est le type, donc ce que la méthode/fonction va retourner, le reste sont des paramètres

```c#
// Appel de la méthode F

FSuperior (1,2,Add); // 3

double Add (int a, int b)
{
    return Convert.ToDouble(a+b);
}
```

### Séquence 2 03.09.2025

```c#
class Animal {
  private string _name; // <---- attribut, private est la lisibilité
  public string Animal { // <----- propriété, va chercher une valeur et l'attribuer
    get => _name
    set => _name = value
  }
}
```

protected -> va juste rester dans la classe et va apparaître quand il y aura de l'héritage
static -> casse l'héritage, relié à la classe, donc si on change pour un il va changer pour tous
abstract -> on peut pas instancier, on peut que hériter

## Filter

- Where -> LinQ, c'est comme du SQL
  - Pour tout ce qui est IEnumerable = nombre, qu'on peut compter, collection, etc.

```c#
List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};
List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
```

== est un comparateur, donc utilisé seulement en condition

```c#
bool lambda(int x)
if (x % 2 == 0)
{
  return true
}
else return false

ou bien

return (x % 2 == 0)
```

Filtrage d'une liste de personnes

```c#
List<Person> people = new New List<Person>{
  new Person ...
  new Person ...
  new Person ...
}

List<Person> adults = people.Where(p => p.Age <= 18).toList();
```

## Lambda

- Fonction anonyme

  - Paramètres d'entrée
  - Corps

- Syntaxe
  - (arg0,arg1,arg2) => CORPS_SIMPLE
  - (arg0,arg1) => {CORPS_COMPLEXE}

```c#
PrintOdd = x => {}

x est le paramètre
```

## Fonction d'ordre supérieur

- Fonction qui a comme paramètre, une autre fonction (ou un type normal avec)
- Permet à la fonction Where de recevoir un Lambda

## Fonction Filter

- Elle prend une collection (liste) et une condition
- Retourne une nouvelle collection qui correspond à la condition, avec certains éléments de la collection

### Filtrages avancés

```c#
numbers.Where(n => n > 2).Where(n => n % 2 == 0); // on faire 2 Wheres enchainés

numbers.Where(n => n > 2 && n % 2 == 0); //condition avec && logique en lambda

//version avec une fonction complète
numbers.Where(n => {
 return n>2 && n % 2 == 0;
});
```

# Important

- Chaque objet a une fonction ToString() par défaut, donc si on fait

```c#
public override string ToString() {
  return "....."
}
```

- Cela sert à afficher quelque chose customisé au moment où on doit "afficher un objet" avec Console.Writeline

### Séquence 3 10.09.2025

- Correction de l'exercice Words

## Fonction Map

Immutabilité

- Select => va selectionner des string(ou autre chose) d'une liste

```c#
IEnumerable<string> names = cid5d.Select(person => person.Name).ToList
```

- Select
  - Modification de valeurs

```c#
IEnumerable<int> numberOfSiblings = cid5d.Select(person => person.Sisters + person.Brothers);
```

- Tuple = Structure de données

  - On met les valeurs dans les parenthèses (1, 2, ...), puis ensuite si on veut les utiliser ils deviennent des Item. Donc on retrouve Item1, Item2, etc.
  - Après on fait un Where, qui va vérifier chaque valeur en la comparant avec le Item. (exemple)

- Classes anonymes

```c#
var anon = new (first=1, second=2, third=3);
Console.WriteLine(anon.first);
Console.WriteLine(anon.second);
Console.WriteLine(anon.third);
```

- Dictionary/ToDictionary
  - Comme si on fait un GroupBy. On lui donne un ID
  - exemple :
  ```c#
  Dictionary<int, Person> dico;
  Person toto = dico[712]
  // plus rapide avec le Dictionary qu'avec LinQ
  List<Person> people;
  Person toto = people.Where(p => p.Id == 712).First();
  ```
