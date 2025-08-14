
Technique de base : action / func
3 catégories principales: Filter, Map, Reduce
Hybrides (map/filter): join
Secondaires: Générateur, Convertisseurs

| activité          | status (TODO/WIP/DONE) | action,func | where (F) | take,skip,last,first,elementat,single,default (F) | distinct,union,intersect,except (F) | reverse | select (M) | groupby (M) | join (MF) | orderby (M) | zip,concat,selectmany (M) | range,repeat,empty (G) | aggregate (R) | count,sum,average (R) | ToList, ToDictionary... (C) |
|-------------------|:----------------------:|:-----------:|-----------|---------------------------------------------------|-------------------------------------|---------|------------|-------------|-----------|-------------|---------------------------|------------------------|---------------|-----------------------|-----------------------------|
| epsilon (filter1) | TODO                   | #1          | #1        | #1                                                | #1                                  |         |            |             |           |             |                           |                        |               |                       |                             |
| filecount         | TODO                   | #1          | #1        | #1                                                | #1                                  | #1      |            |             |           |             |                           |                        |               |                       |                             |
| marché            | TODO                   | x           | x         | x                                                 | x                                   | x       | #2         | #2          | #2        | #2          | #2                        |                        |               |                       |                             |
| swapi             | TODO                   |             |           |                                                   |                                     |         |            |             |           |             |                           | #3                     | #3            | #3                    | #3                          |
| linqorne          | TODO                   |             |           |                                                   |                                     |         |            |             |           |             |                           |                        |               |                       |                             |
