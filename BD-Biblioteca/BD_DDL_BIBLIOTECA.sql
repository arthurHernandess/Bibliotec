DROP SCHEMA IF EXISTS BiblioTec;
CREATE SCHEMA BiblioTec;
USE BiblioTec;

DROP TABLE IF EXISTS editora;

CREATE TABLE  editora 
(
  cd_editora INT,
  nm_editora VARCHAR(200),
  CONSTRAINT pk_editora PRIMARY KEY (cd_editora) 
);

CREATE TABLE  livro 
(
  cd_livro INT,
  cd_ISBN VARCHAR(200),
  nm_livro TEXT,
  aa_edicao INT,
  ds_sinopse TEXT,
  cd_editora INT,
  img_capa longblob,
  CONSTRAINT pk_livro PRIMARY KEY (cd_livro),
  CONSTRAINT fk_livro_editora1 FOREIGN KEY (cd_editora)
    REFERENCES editora (cd_editora)
);

CREATE TABLE  autor 
(
  cd_autor INT,
  nm_autor VARCHAR(200),
  CONSTRAINT pk_autor PRIMARY KEY (cd_autor) 
);

CREATE TABLE  categoria 
(
  cd_categoria INT,
  nm_categoria VARCHAR(200),
  CONSTRAINT pk_categoria PRIMARY KEY (cd_categoria) 
);

CREATE TABLE  livro_categoria 
(
  cd_livro INT,
  cd_categoria INT,
  CONSTRAINT pk_livro_cat PRIMARY KEY (cd_livro, cd_categoria) ,
  CONSTRAINT fk_livro_categoria_livro1 FOREIGN KEY (cd_livro)
    REFERENCES livro (cd_livro),
  CONSTRAINT fk_livro_categoria_categoria1 FOREIGN KEY (cd_categoria)
    REFERENCES categoria (cd_categoria)
);

CREATE TABLE  localizacao 
(
  cd_localizacao INT,
  nm_localizacao VARCHAR(255),
  CONSTRAINT pk_localizacao PRIMARY KEY (cd_localizacao)
);

CREATE TABLE  exemplar 
(
  cd_exemplar INT,
  cd_livro INT,
  cd_rfid INT,
  ic_fixo TINYINT(1),
  cd_localizacao INT,
  CONSTRAINT pk_exemplar PRIMARY KEY (cd_exemplar, cd_livro),
  CONSTRAINT fk_exemplar_livro1 FOREIGN KEY (cd_livro)
    REFERENCES livro (cd_livro),
  CONSTRAINT fk_exemplar_localizacao1 FOREIGN KEY (cd_localizacao)
    REFERENCES localizacao (cd_localizacao)
);


CREATE TABLE  tipo_usuario 
(
  cd_tipo_usuario INT,
  nm_tipo_usuario VARCHAR(45),
  CONSTRAINT pk_tipo_usuario PRIMARY KEY (cd_tipo_usuario)
);

CREATE TABLE  usuario 
(
  nm_login VARCHAR(200),
  nm_usuario VARCHAR(255),
  nm_senha VARCHAR(64),
  ic_bloqueado TINYINT(1),
  dt_bloqueio DATE,
  cd_tipo_usuario INT,
  CONSTRAINT pk_usuario PRIMARY KEY (nm_login),
  CONSTRAINT fk_usuario_tipo_usuario1 FOREIGN KEY (cd_tipo_usuario)
    REFERENCES tipo_usuario (cd_tipo_usuario)
);

CREATE TABLE  tipo_emprestimo 
(
  cd_tipo_emprestimo INT,
  nm_tipo_emprestimo VARCHAR(45),
  CONSTRAINT pk_tipo_emp PRIMARY KEY (cd_tipo_emprestimo)
);

CREATE TABLE  emprestimo 
(
  nm_login VARCHAR(200),
  cd_exemplar INT,
  cd_livro INT,
  dt_emprestimo DATE,
  hr_emprestimo TIME,
  dt_devolucao_estimada DATE,
  dt_devolucao DATE,
  cd_tipo_emprestimo INT,
  CONSTRAINT pk_emp PRIMARY KEY (nm_login, cd_exemplar, cd_livro, dt_emprestimo),
  CONSTRAINT fk_usuario_exemplar_usuario1 FOREIGN KEY (nm_login)
    REFERENCES usuario (nm_login),
  CONSTRAINT fk_usuario_exemplar_exemplar1 FOREIGN KEY (cd_exemplar , cd_livro)
    REFERENCES exemplar (cd_exemplar , cd_livro),
  CONSTRAINT fk_emprestimo_tipo_emprestimo1 FOREIGN KEY (cd_tipo_emprestimo)
    REFERENCES tipo_emprestimo (cd_tipo_emprestimo)
);

CREATE TABLE  tipo_ocorrencia 
(
  cd_tipo_ocorrencia INT,
  nm_tipo_ocorrencia VARCHAR(45),
  CONSTRAINT pk_tipo_ocorrencia PRIMARY KEY (cd_tipo_ocorrencia)
);

CREATE TABLE  ocorrencia 
(
  nm_login VARCHAR(200),
  cd_exemplar INT,
  cd_livro INT,
  dt_emprestimo DATE,
  cd_tipo_ocorrencia INT,
  ds_ocorrencia TEXT,
  CONSTRAINT pk_ocorrencia PRIMARY KEY (nm_login, cd_exemplar, cd_livro, dt_emprestimo, cd_tipo_ocorrencia) ,
  CONSTRAINT fk_emprestimo_tipo_ocorrencia_emprestimo1 FOREIGN KEY (nm_login , cd_exemplar , cd_livro , dt_emprestimo)
    REFERENCES emprestimo (nm_login , cd_exemplar , cd_livro , dt_emprestimo),
  CONSTRAINT fk_emprestimo_tipo_ocorrencia_tipo_ocorrencia1 FOREIGN KEY (cd_tipo_ocorrencia)
    REFERENCES tipo_ocorrencia (cd_tipo_ocorrencia)
);

CREATE TABLE  computador 
(
  dt_uso_computador DATE,
  nm_login VARCHAR(200),
  CONSTRAINT pk_computador PRIMARY KEY (dt_uso_computador, nm_login) ,
  CONSTRAINT fk_computador_usuario1 FOREIGN KEY (nm_login)
    REFERENCES usuario (nm_login)
);

CREATE TABLE  livro_autor 
(
  cd_livro INT,
  cd_autor INT,
  CONSTRAINT pk_livro_autor PRIMARY KEY (cd_livro, cd_autor),
  CONSTRAINT fk_livro_autor_livro1 FOREIGN KEY (cd_livro)
    REFERENCES livro (cd_livro),
  CONSTRAINT fk_livro_autor_autor1 FOREIGN KEY (cd_autor)
    REFERENCES autor (cd_autor)
);

