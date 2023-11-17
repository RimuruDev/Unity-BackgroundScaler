﻿# BackgroundScaler для Unity

## Обзор
`BackgroundScaler` - это компонент для Unity, предназначенный для автоматического масштабирования фоновых изображений на основе `SpriteRenderer`. Этот скрипт гарантирует, что фон остается в пределах видимости экрана независимо от его разрешения и формата, будь то 1920x1080, 5000x800 и т.д.

## Как использовать
1. Добавьте скрипт `BackgroundScaler` к GameObject, который содержит `SpriteRenderer` с фоновым изображением.
2. В инспекторе Unity укажите камеру в поле `Camera Renderer`. Эта камера будет использоваться для определения размеров фона.

## Особенности
- Автоматически масштабирует фон так, чтобы он полностью покрывал видимую область камеры.
- Поддерживает различные соотношения сторон экрана.
- Работает в режиме реального времени, подстраиваясь под изменения размеров окна игры или экрана.

## Контакты
Если у вас возникнут вопросы или предложения, связанные с этим скриптом, вы можете связаться со мной следующими способами:
- Gmail: [rimuru.dev@gmail.com](mailto:rimuru.dev@gmail.com)
- LinkedIn: [Профиль на LinkedIn](https://www.linkedin.com/in/rimuru/)
- Gists: [Gist на GitHub](https://gist.github.com/RimuruDev/61e9f0111b35d3e67ef18fab611d7595)

## Лицензия
Этот скрипт распространяется на условиях лицензии, указанной в начале исходного файла. Все права защищены © RimuruDev.
