using Zoo;

Aviary bigAviary = new Aviary("для слонов", "тропики", 500);

List<AbstractAnimals> elephant = new List<AbstractAnimals>()
{
    new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Мира", 300, 4, "трубить хоботом"),
    new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Боря", 300, 5, "трубить хоботом")
};
bigAviary.ListAnimals(elephant);

ElephantAnimals elephantFaina = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "аууф", "Фаина", 300, 4, "трубить хоботом");

List<AbstractAnimals> newElephant;
newElephant = bigAviary.PlusAnimal(elephant, elephantFaina);

ElephantAnimals elephantDoby = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауууф", "Доби", 250, 1, "трубить хоботом");

List<AbstractAnimals> new2Elephant;
new2Elephant = bigAviary.PlusAnimal(newElephant, elephantDoby);

List<AbstractAnimals> new3Elephant;
new3Elephant = bigAviary.MinusAnimal(new2Elephant, elephantFaina);

bigAviary.FeedAnimals(newElephant, 800, "сено");

bigAviary.MakeASoundAllAnimals(newElephant);



Aviary penguinAviary = new Aviary("для пингвинов", "тундра", 50);

List<AbstractAnimals> penguin = new List<AbstractAnimals>()
{
new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гргргр", "Толик", 0.3, 1, "плавать"),
new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гргр", "Симба", 0.35, 3, "плавать"),
new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гргргр", "Руби", 0.4, 3, "плавать")
};

penguinAviary.ListAnimals(penguin);

PenguinAnimals penguinSonya = new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гр", "Соня", 0.3, 2, "плавать");

List<AbstractAnimals> newPenguin;
newPenguin = penguinAviary.PlusAnimal(penguin, penguinSonya);


List<AbstractAnimals> new2Penguin;
new2Penguin = penguinAviary.MinusAnimal(newPenguin, penguin[0]);

penguinAviary.FeedAnimals(new2Penguin, 1.15, "рыба");

penguinAviary.MakeASoundAllAnimals(new2Penguin);