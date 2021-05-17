# castle-meme
## Об приложении
Этот веб сервис предоставляет возможность загружать, просматривать и оценивать ролики. Можно подписаться на пользователя *Castle'ра*, написать что-то под его роликом, или же просто оценить его ролик, продвигайте свои ролики вместе с Castle! 
## Стек
### Backend
- С#
- [asp net](https://metanit.com/sharp/aspnet5/)
### Frontend
- css
- javascript
- html
- bootstrap
## Об архетектуре
приложение написано на asp net и использует паттерн проектирования [MVC](https://ru.wikipedia.org/wiki/Model-View-Controller), пробежимся по папкам, их назначению и содержимому:
- [wwwroot](//github.com/OnlyM1ss/castle-meme/tree/main/castle_web/castle_web/wwwroot)
  - css
  - js
  - lib хранит в себе bootstrap,jquery и т.д
  - Videos тут содержатся ролики, загруженные на castle
- [Areas](//github.com/OnlyM1ss/castle-meme/tree/main/castle_web/castle_web/Areas/) 
  - [identity](//metanit.com/sharp/aspnet5/16.1.php) аутентификация и авторизация
- [Controllers](github.com/OnlyM1ss/castle-meme/tree/main/castle_web/castle_web/Controllers) контроллеры, отвечающие за логику, обработку, редирект и прочие штуки нашего сайта, полезно почитать [тут](//metanit.com/sharp/aspnet5/5.1.php), к каждойвьюхе привязан свой контроллер по принципу *имя вьюхи*Controller
- Data хранит историю [миграций](//metanit.com/sharp/entityframework/3.12.php) и [контекст](//metanit.com/sharp/mvc5/12.3.php) нашей базы данных
- [Helpers](//github.com/OnlyM1ss/castle-meme/tree/main/castle_web/castle_web/Helpers) хранит в себе вспомогательные методы, к примеру [генерацию юрл для видео](https://github.com/OnlyM1ss/castle-meme/blob/main/castle_web/castle_web/Helpers/GenerateUrl.cs)
- [Models](//github.com/OnlyM1ss/castle-meme/tree/main/castle_web/castle_web/Models) модели приложения, т.е сушности(классы и структуры) нашего приложения, описывающие "действущих лиц" в нашем цирке уродов XD
- [Repository](//github.com/OnlyM1ss/castle-meme/tree/main/castle_web/castle_web/Repository) тут у нас управление с базой данных, пока определил общий интерфейс [IVideoRepository](https://github.com/OnlyM1ss/castle-meme/blob/main/castle_web/castle_web/Repository/IVideoRepository.cs) он отвечает за общую логику работы как и с локальной бд, так и с api(пока нет) смотри паттерн [стратегия](//refactoring.guru/ru/design-patterns/strategy) 
- ViewModel смотри [вот этот прикол](//metanit.com/sharp/mvc5/5.17.php) это такие специальные модели, которые, грубо говоря, надстройки над основными сущностями(классами и структурами)
- Views представления(front часть сервиса), некоторые написаны на [razor](//metanit.com/sharp/aspnet5/7.2.php)
