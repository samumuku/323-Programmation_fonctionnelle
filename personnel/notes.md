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
