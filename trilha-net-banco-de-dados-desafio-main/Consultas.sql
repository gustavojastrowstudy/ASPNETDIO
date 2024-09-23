SELECT Nome, Ano
FROM Filmes;

SELECT Nome, Ano
FROM Filmes
ORDER BY Ano ASC;

SELECT Nome, Ano, Duracao
FROM Filmes
WHERE Nome = 'De Volta Para o Futuro';

SELECT Nome, Ano
FROM Filmes
WHERE Ano = 1997;

SELECT Nome, Ano
FROM Filmes
WHERE Ano > 2000;

SELECT Nome, Duracao
FROM Filmes
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao ASC;

SELECT Ano, COUNT(*) AS Quantidade
FROM Filmes
GROUP BY Ano
ORDER BY Quantidade DESC;

SELECT PrimeiroNome, UltimoNome
FROM Atores
WHERE Genero = 'M';

SELECT PrimeiroNome, UltimoNome
FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome ASC;

SELECT f.Nome AS Filme, g.Genero
FROM Filmes f
JOIN FilmesGenero fg ON f.Id = fg.IdFilme
JOIN Generos g ON fg.IdGenero = g.Id;

SELECT f.Nome AS Filme, g.Genero
FROM Filmes f
JOIN FilmesGenero fg ON f.Id = fg.IdFilme
JOIN Generos g ON fg.IdGenero = g.Id
WHERE g.Genero = 'Mistério';

SELECT f.Nome AS Filme, a.PrimeiroNome, a.UltimoNome, e.Papel
FROM Filmes f
JOIN ElencoFilme e ON f.Id = e.IdFilme
JOIN Atores a ON e.IdAtor = a.Id;
