select 
    l . *,
    e.nm_editora as Editora,
    group_concat(distinct (l_au.cd_autor)) as 'Código autores',
    group_concat(distinct (au.nm_autor)) as Autores,
    group_concat(distinct (l_cat.cd_categoria)) as 'Código categoria',
    group_concat(distinct (cat.nm_categoria)) as Categorias
from
    livro l
        join
    editora e ON (l.cd_editora = e.cd_editora)
        join
    livro_autor l_au ON (l.cd_livro = l_au.cd_livro)
        join
    autor au ON (l_au.cd_autor = au.cd_autor)
        join
    livro_categoria l_cat ON (l.cd_livro = l_cat.cd_livro)
        join
    categoria cat ON (cat.cd_categoria = l_cat.cd_categoria)
group by l.cd_livro;


select 
    l . *, group_concat(e.cd_exemplar)
from
    livro l
        join
    exemplar e ON (l.cd_livro = e.cd_livro)
group by l.cd_livro;


select 
    ex . *, l . *
from
    exemplar ex
        join
    localizacao l ON (ex.cd_localizacao = l.cd_localizacao)
where
    cd_livro = 1;



select 
    em.*, l.nm_livro, tem.nm_tipo_emprestimo
from
    emprestimo em
        join
    tipo_emprestimo tem ON (em.cd_tipo_emprestimo = tem.cd_tipo_emprestimo)
		join
	exemplar ex on (em.cd_livro = ex.cd_livro and em.cd_exemplar = ex.cd_exemplar)
		join
	livro l on (em.cd_livro = l.cd_livro);

UPDATE emprestimo 
SET 
    dt_devolucao = '2022-11-16'
WHERE
    em.cd_livro = 1 and em.nm_login = 35123 and em.cd_exemplar = 9 and dt_emprestimo = null;


select 
    *
from
    exemplar;
select 
    *
from
    usuario;
select 
    *
from
    livro;

