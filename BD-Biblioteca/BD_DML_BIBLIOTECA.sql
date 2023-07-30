INSERT INTO editora (cd_editora, nm_editora) VALUES (1, 'Editora FTD');
INSERT INTO editora (cd_editora, nm_editora) VALUES (2, 'Companhia de Letras');
INSERT INTO editora (cd_editora, nm_editora) VALUES (3, 'Aleph');
INSERT INTO editora (cd_editora, nm_editora) VALUES (4, 'Suma');
INSERT INTO editora (cd_editora, nm_editora) VALUES (5, 'Editora Intrínseca');
INSERT INTO editora (cd_editora, nm_editora) VALUES (6, 'Grupo Editorial Record');
INSERT INTO editora (cd_editora, nm_editora) VALUES (7, 'Editora Rocco');
INSERT INTO editora (cd_editora, nm_editora) VALUES (8, 'Globo Livros');
INSERT INTO editora (cd_editora, nm_editora) VALUES (9, 'Darkside Books');
INSERT INTO editora (cd_editora, nm_editora) VALUES (10, 'Harper Collins');
INSERT INTO editora (cd_editora, nm_editora) VALUES (11, 'Editora Arqueiro');

INSERT INTO autor (cd_autor, nm_autor) VALUES (1, 'H.P. LoveCraft');
INSERT INTO autor (cd_autor, nm_autor) VALUES (2, 'J.K. Rowling');
INSERT INTO autor (cd_autor, nm_autor) VALUES (3, 'Machado de Assis');
INSERT INTO autor (cd_autor, nm_autor) VALUES (4, 'Fredê Arco e Flexa');
INSERT INTO autor (cd_autor, nm_autor) VALUES (5, 'Tavares');
INSERT INTO autor (cd_autor, nm_autor) VALUES (6, 'Denise Lacradora');
INSERT INTO autor (cd_autor, nm_autor) VALUES (7, 'José de Alencar');
INSERT INTO autor (cd_autor, nm_autor) VALUES (8, 'William Shakespeare');
INSERT INTO autor (cd_autor, nm_autor) VALUES (9, 'Carlos Drummond de Andrade');
INSERT INTO autor (cd_autor, nm_autor) VALUES (10,'Clarice Lispector');
INSERT INTO autor (cd_autor, nm_autor) VALUES (11,'Lima Barreto');

INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (1, 'Ação');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (2, 'Fantasia');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (3, 'Terror');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (4, 'Aventura');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (5, 'Romance');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (6, 'Crítica Social');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (7, 'Suspense');

INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (1, '8532223796', 'Matematica - V. 3 - Geometria Analitica, Numeros Complexos E Polinomio', 2021, NULL, 1);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (2, '987654631', 'Harry Potter 15', 2022, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 1);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (3, '02311651654', 'Senhor dos Aneis', 1800, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 3);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (4, '35715954712', 'De Volta pro Passado', 2000, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 3);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (5, '56546579854', 'Matrix', 2020, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 4);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (6, '78984564561', 'Geografia e Biologia', 1900, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 5);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (7, '56846845613', 'As Crônicas Nárnia', 1901, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 6);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (8, '31313144449', 'Transformers', 2001, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 7);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (9, '98765654564', 'Diário de um Banana', 2000, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 8);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (10, '65753435321', 'Pequeno Príncipe', 2022, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 9);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (11, '13213546421', 'Percy Jackson', 1900, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 10);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (12, '98451515127', 'A Arte de Ligar o Foda-se', 1999, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 10);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (13, '35768543560', 'Lolita', 2022, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 2);
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora) VALUES (14, '00214555541', 'Fredê e Suas Aventuras', 1700, 'Professora Paula esclarece as principais dúvidas de química de alunos do 2° ano', 3);

INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (1, 1);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (1, 3);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (2, 2);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (3, 4);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (4, 5);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (5, 5);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (6, 6);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (7, 7);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (8, 8);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (9, 9);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (10, 10);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (11, 10);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (11, 1);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (12, 10);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (13, 1);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (14, 1);

INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (1, 1);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (2, 1);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (3, 2);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (4, 3);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (5, 4);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (6, 5);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (7, 6);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (7, 7);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (8, 7);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (14, 1);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (9, 1);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (10, 2);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (11, 3);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (12, 6);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (13, 5);
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (14, 5);

INSERT INTO localizacao (cd_localizacao, nm_localizacao) VALUES (1, 'E02C01P01 - Estante 02 - Coluna 01 - Prateleira 01');

INSERT INTO localizacao (cd_localizacao, nm_localizacao) VALUES (2, 'E03C02P02 - Estante 03 - Coluna 02 - Prateleira 02');

INSERT INTO tipo_usuario (cd_tipo_usuario, nm_tipo_usuario) VALUES (1, 'Admin');
INSERT INTO tipo_usuario (cd_tipo_usuario, nm_tipo_usuario) VALUES (2, 'Operador');
INSERT INTO tipo_usuario (cd_tipo_usuario, nm_tipo_usuario) VALUES (3, 'Cliente');

INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('admin', 'Administrador', '123', 0, NULL, 1);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('operador', 'Operador', '123', 0, NULL, 2);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('12577', 'Frederico Arco e Flexa Machado Justo', '123', 0, NULL, 3);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('36338', 'Arthur de Lima Hernandes', '123', 0, NULL, 3);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('36416', 'Fábio Maia Santana Júnior', '123', 0, NULL, 3);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('36401', 'Alisson Ramos', '123', 1, '2022-11-08', 3);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('36404', 'Filipi', '123', 0, NULL, 3);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('35123', 'Afonso', '123', 0, NULL, 3);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('13246', 'Edson Leguth', '123', 0, NULL, 3);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('78945', 'Luiz Tavares', '123', 0, NULL, 3);

INSERT INTO tipo_emprestimo (cd_tipo_emprestimo, nm_tipo_emprestimo) VALUES (1, 'Consulta');
INSERT INTO tipo_emprestimo (cd_tipo_emprestimo, nm_tipo_emprestimo) VALUES (2, 'Empréstimo');

INSERT INTO tipo_ocorrencia (cd_tipo_ocorrencia, nm_tipo_ocorrencia) VALUES (1, 'Devolução com leve dano');
INSERT INTO tipo_ocorrencia (cd_tipo_ocorrencia, nm_tipo_ocorrencia) VALUES (2, 'Devolução com grave dano');





/* INSERT EXEMPLARES */
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 1, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 1, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 1, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 1, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (5, 1, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (6, 1, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (7, 1, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 2, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 2, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 2, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 2, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 3, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 3, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 4, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 4, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 4, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 4, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (5, 4, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (6, 4, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (7, 4, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 5, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 5, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 5, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 5, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (5, 5, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (6, 5, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 6, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 6, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 6, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 6, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (5, 6, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (6, 6, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 7, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 7, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 7, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 7, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (5, 7, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (6, 7, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (7, 7, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 8, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 8, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 8, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 8, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (5, 8, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (6, 8, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (7, 8, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (8, 8, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 9, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 9, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 9, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 10, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 10, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 10, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 10, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (5, 10, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (6, 10, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (6, 11, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 12, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 12, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 12, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 12, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (5, 12, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 13, 1, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 13, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (3, 13, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (4, 13, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (5, 13, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (6, 13, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (7, 13, 0, 1);

INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (1, 14, 0, 1);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao) VALUES (2, 14, 0, 1);






