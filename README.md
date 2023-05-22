# "Планета слизняков"
## "Планета слизняков" - простая игра-платформер, написанная на языке программирования С#
#### Предыстория игры 
Студент-выпускник программы "Электроника и наноэлектроника" для своей дипломной работы в качестве проекта взял создание машины-телепорта. При тестировании аппарата студент допустил вычислительную ошибку, вследствие чего он вместе с телепортом переместился на необычную планету, которую населяли только слизняки, одно прикосновение к которым может убить человека. При телепортации машина была разрушена. Чтобы починить ее и вернуться на Землю, Вам придется найти инструменты.
<img width="468" alt="menu" src="https://github.com/PalastrovaS/PlatformGame/assets/130470961/7f5aebc0-9040-4ac7-8ff2-0bed5ed5c2c6">

### Игровые механики
Передвидение персонажа осуществляется с клавиатуры за счет стрелок <b>"вправо"</b> и <b>"влево"</b> для перемещение соответственно вправо и влево и <b>пробела</b> для совершения прыжка

<b>Виды платформ:</b>
<ul>
 <li>Платформы, движущиеся в горизонтальном и вертикальном направлениях</li>
 <img width="97" alt="vertical_platform" src="https://github.com/PalastrovaS/PlatformGame/assets/130470961/fc40a829-c3b1-4faa-b0b4-4a1ddd29d80e">
 <img width="151" alt="horizontal_platform" src="https://github.com/PalastrovaS/PlatformGame/assets/130470961/bac0a9b7-fe38-44ea-8062-07c17134aac7">
 <li>Статичные платформы</li>
 <li>Платформы-телепорты (появляются на втором уровне)</li>
 <img width="192" alt="teleport_platform" src="https://github.com/PalastrovaS/PlatformGame/assets/130470961/00857050-76b6-4164-a6ea-2cf46a426c0c">
</ul>
<b>Виды врагов:</b>
<ul>
 <li>Статичные слизняки</li>
 <img width="132" alt="static_enemy" src="https://github.com/PalastrovaS/PlatformGame/assets/130470961/812f8026-1060-47e1-a82e-6bfc2623e879">
 <li>"Патрульные" (слизняки, способные перемещаться вдоль платформы, на которой они находятся)</li>
 <img width="164" alt="moving_enemy" src="https://github.com/PalastrovaS/PlatformGame/assets/130470961/f82f1de2-58a0-44fa-a6f1-96f0e7f66c97">
</ul>

При столкновении со слизняками игрок умирает. Также его смерть наступает при контакте с болотом (находится в нижней части экрана на первом уровне) и ледяным озером (находится в нижней части экрана на втором уровне). У игроков есть возможность пачать проходить уровень заново, если он умрет. Количество жизней в игре не ограничено.
Для того, чтобы пройти уровень, игрок должен найти инструмент и дойти до телепорта, чтобы починить его.

