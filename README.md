# databases_Konovalenko
Створення додатку бази даних, орієнтованого на взаємодію з СУБД PostgreSQL
Предметна галузь «Електронний каталог для зберігання музичних нот та композицій»

СТРУКТУРА БД
Таблиці та їхні атрибути:
composition - інформація про музичні композиції:
composition_id (integer) – унікальний ідентифікатор композиції.
title (character varying) – назва композиції.
duration (integer) – тривалість композиції (у хвилинах).
year (integer) – рік створення композиції.
genre_id (integer) – ідентифікатор жанру.

sheet_music - нотні записи композицій:
sheet_music_id (integer) – унікальний ідентифікатор нот.
name (character varying) – назва файлу нот.
format (character varying) – формат файлу нот.
composition_id (integer) – ідентифікатор композиції.

author - інформація про авторів:
author_id (integer) – унікальний ідентифікатор автора.
name (character varying) – ім’я автора.
surname (character varying) – прізвище автора.

genre - жанри композицій:
genre_id (integer) – унікальний ідентифікатор жанру.
name (character varying) – назва жанру.

composition_author - зв’язок авторів із композиціями:
composition_author_id (integer) – унікальний ідентифікатор зв’язку.
composition_id (integer) – ідентифікатор композиції.
author_id (integer) – ідентифікатор автора.
