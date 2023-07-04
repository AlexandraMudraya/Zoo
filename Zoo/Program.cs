using Zoo;

//CatAnimals catLeopold = new CatAnimals("кот", "повсеместно", 10, "корм для кошек и рыба", "хищник", "мяу", "Леопольд", 0.07, 2);
//CatAnimals catVasya = new CatAnimals("кот", "повсеместно", 10, "корм для кошек и рыба", "хищник", "мяу", "Вася", 0.075, 3);

//catLeopold.Eat("корм для кошек", 0.07);
//catLeopold.CanDo();
//catLeopold.Play("кот", "Вася");
//catVasya.MakeASound();

//Console.WriteLine();

//PenguinAnimals penguinTolik = new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гргргр", "Толик", 0.3, 1);
//PenguinAnimals penguinSimba = new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гргргр", "Симба", 0.35, 3);

//penguinTolik.Eat("рыба", 0.4);
//penguinTolik.CanDo();
//penguinTolik.Play("пингвин", "Симба");
//penguinSimba.MakeASound();

//Console.WriteLine();

//BearAnimals bearMasha = new BearAnimals("медведь", "лес", 50, "рыба, орехи, ягоды", "хищник", "арррр", "Маша", 5, 2);
//BearAnimals bearMisha = new BearAnimals("медведь", "лес", 50, "рыба, орехи, ягоды", "хищник", "арррр", "Миша", 7, 4);

//bearMasha.Eat("рыба", 4);
//bearMasha.CanDo();
//bearMasha.Play("пингвин", "Симба");
//bearMisha.MakeASound();

//Console.WriteLine();

//ElephantAnimals elephantBorya = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Боря", 300, 5);
//ElephantAnimals elephantMira = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Мира", 300, 4);

//elephantBorya.Eat("сено", 301);
//elephantBorya.CanDo();
//elephantBorya.Play("слон", "Мира");
//elephantMira.MakeASound();

//Console.WriteLine();

//BirdAnimals birdGosha = new BirdAnimals("попугай", "тропики", 10, "фрукты, корм для птиц", "травоядный", "чик-чирик", "Гоша", 0.03, 6);
//BirdAnimals birdKesha = new BirdAnimals("воробей", "лес", 10, "фрукты, корм для птиц", "травоядный", "чик-чирик", "Кеша", 0.03, 2);

//birdGosha.Eat("фрукты", 0.03);
//birdGosha.CanDo();
//birdGosha.Play("воробей", "Кеша");
//birdKesha.MakeASound();



Aviary bigAviary = new Aviary("вольер для слонов", "тропики", 1000);

ElephantAnimals[] elephant =  new ElephantAnimals[2];

elephant[0] = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Боря", 300, 5);
elephant[1] = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Мира", 300, 4);

bigAviary.ListAnimals(elephant);

ElephantAnimals elephantFaina = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Фаина", 300, 4);


AbstractAnimals[] x = new ElephantAnimals[5];

x = bigAviary.PlusAnimal(bigAviary, elephant, elephantFaina);

bigAviary.ListAnimals(elephant);


//bigAviary.MinusAnimal(bigAviary, elephant, elephantFaina);