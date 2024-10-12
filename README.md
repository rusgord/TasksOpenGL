# Репозиторій для практичних робіт з M1.OpenGL.
## Системна Інформація
- Processor	AMD Ryzen 5 5600 6-Core Processor 3.50 GHz
- RAM	32.0 GB (31.9 GB usable)
- System type	64-bit operating system, x64-based processor
- Edition	Windows 11 Home Version 23H2
- IDE	Microsoft Visual Studio Enterprise 2022 (64-bit) version 17.11.4
## Практична робота №1. Основні принципи роботи з OpenGL
### Мета роботи

За допомогою інструментальних засобів, зазначених викладачем, створити простий програмний проєкт із підтримкою бібліотеки OpenGL. Розробити програму із застосуванням команд OpenGL, яка встановлює анізотропну систему координат, створює та виводить варіант зображення на екран/у вікно з урахуванням заданих примітивів та координат x1, y1 та x2, y2 . Для рисування координатної сітки необхідно використовувати пунктирні лінії. Контур фігури, осі та координатну сітку зобразити лініями різної товщини. Для парних варіантів точки повинні мати квадратну форму, а для непарних – круглу

### Виконання роботи
Для управління параметрами графічних примітивів було використано наступні команди:
̶	колір, glColor3ub() рядок 19 у файлі FirstTasks.cs;
̶	тип, glLineStipple(), glEnable()/glDisable(), рядок 17 у файлі FirstTasks.cs;
̶	товщина glLineWidth(), рядок 45 у файлі FirstTasks.cs
Коректне відображення завдання під час змінення розмірів/положення вікна наведено у рис. 1.1 та 1.2
Розроблення підпрограм для виключення дублювання коду наведено у рядках 34 – 59 файлу FirstTasks.cs
Застосування циклів для створення зображень наведено у рядках 21 – 30 файлу FirstTasks.cs.
Використання ООП реалізовано за допомогою розроблення власних класів, які наведено у файлах Figure.cs.
![Screenshot1.1 - testing the program when changing the window width](Screenshots/Screenshot_1_lab1.png)

Рисунок 1.1 – Тестування програми при зміні ширини вікна

![Screenshot1.2 - testing the program when changing the window height](Screenshots/Screenshot_2_lab1.png)

Рисунок 1.2 – Тестування програми при зміні висоти вікна

### Контроль виконання вимог та елементів завдання
<table>
  <tr>
    <th>№ з/п</th>
    <th>Складність</th>
    <th>Вимоги</th>
    <th>Бали</th>
    <th>Зроблено</th>
  </tr>
  <tr>
    <td>1</td>
    <td rowspan="4">Базовий рівень</td>
    <td>Використання команд управління параметрами графічних примітивів (колір, тип, товщина)</td>
    <td>2</td>
    <td>+</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Коректне відображення завдання під час змінення розмірів/положення вікна</td>
    <td>1</td>
    <td>+</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Розроблення підпрограм для виключення дублювання коду</td>
    <td>1</td>
    <td>+</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Застосування циклів для створення зображень</td>
    <td>1</td>
    <td>+</td>
  </tr>
  <tr>
    <td>5</td>
    <td rowspan="2">Підвищений рівень</td>
    <td>Формування зображення векторними командами OpenGL (glDrawArrays і т. п.)</td>
    <td>1</td>
    <td>-</td>
  </tr>
  <tr>
    <td>6</td>
    <td>Використання ООП (розроблення власних класів)</td>
    <td>2</td>
    <td>+</td>
  </tr>
</table>


## Практична робота №2. Графічні примітиви OpenGL
### Мета роботи

Вивчити поняття теселяції і навчитися використовувати графічні примітиви OpenGL для створення поверхонь. Освоїти обробку подій клавіатури і маніпулятора «миша» для створення інтерактивних застосунків.

### Виконання роботи
У даній практичній роботі було розроблено застосунок з використанням бібліотеки OpenGL для відображення правильного багатокутника та можливості замощення області екрану користувачем. Програма реалізована з використанням команд OpenGL для керування примітивами, налаштування координатної системи, відображення фігур та взаємодії з користувачем.
Налаштування координатної системи: 
Використовуються функції glOrtho() та glViewport() для встановлення ізотропної системи координат, що дозволяє відображати багатокутники в центрі вікна незалежно від розмірів області рендерингу. Параметри масштабування визначаються розмірами фігури та кількістю плиток, які буде відображено на екрані.
Коректне відображення завдання під час змінення розмірів/положення вікна наведено у рис. 2.1 та 2.2
Відображення багатокутника: 
Для відображення правильного багатокутника використано примітиви GL_TRIANGLE_STRIP та GL_POLYGON. Після старту програми у робочій області відображається одна плитка. Розмір плитки визначено згідно з варіантом, де сторона фігури дорівнює 50.
Реалізовано три режими відображення фігур:
•	Точковий режим (відображення лише вершин фігури) за допомогою примітиву GL_POINTS.
•	Контурний режим (відображення лише контуру фігури) за допомогою примітиву GL_LINE_LOOP.
•	Режим із заливкою (заповнення кольором) за допомогою примітиву GL_TRIANGLE_STRIP та GL_POLYGON.
Колірна схема: 
Для зафарбування фігур використано шість кольорів: білий, сірий (35%), червоний, зелений, синій та жовтий. Фарба накладається відповідно до положення багатокутників на екрані.

![Screenshot2.1 - testing the program when changing the window width](Screenshots/Screenshot_1_lab2.png)

Рисунок 2.1 – Тестування програми при зміні ширини вікна

![Screenshot2.2 - testing the program when changing the window height](Screenshots/Screenshot_2_lab2.png)

Рисунок 2.2 – Тестування програми при зміні висоти вікна

### Контроль виконання вимог та елементів завдання
<table>
  <tr>
    <th>№ з/п</th>
    <th>Складність</th>
    <th>Вимоги</th>
    <th>Бали</th>
    <th>Зроблено</th>
  </tr>
  <tr>
    <td>1</td>
    <td rowspan="6">Базовий рівень</td>
    <td>Під час запуску застосунку зображення відповідає варіанту завдання з однією плиткою</td>
    <td>1</td>
    <td>+</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Багаторазове замощення плиткою. Кратність замощення задається користувачем під час роботи застосунку</td>
    <td>1</td>
    <td>+</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Коректне відображення завдання під час зміни як розмірів/положення вікна, так і параметрів замощення.</td>
    <td>1</td>
    <td>+</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Організація взаємодії з користувачем одним зі стандартних засобів (клавіатура, «миша» та ін.)</td>
    <td>1</td>
    <td>+</td>
  </tr>
  <tr>
  <tr>
    <td>5</td>
    <td>Застосування мінімальної (у рамках варіанту) кількості графічних примітивів для виконання завдання</td>
    <td>1</td>
    <td>+</td>
  </tr>
  <tr>
    <td>6</td>
    <td rowspan="2">Підвищений рівень</td>
    <td>Створення власних елементів інтерфейсу за допомогою OpenGL</td>
    <td>2</td>
    <td>-</td>
  </tr>
  <tr>
    <td>7</td>
    <td>Використання ООП (розроблення власних класів)</td>
    <td>1</td>
    <td>+</td>
  </tr>
</table>
