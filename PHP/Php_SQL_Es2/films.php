<?php

    $person = $_REQUEST['person'];
    
    $db = new PDO('mysql:host=school.ncoltro.dev;dbname=5ci_ncoltro_2', 'ncoltro_php', 'dmLyOFbbfUgq5D3L');
    $db->exec("set names utf8");

    $q = $db->prepare('
        SELECT DISTINCT film.titolo
        FROM film
        JOIN attivita ON attivita.idFilm = film.id
        WHERE attivita.idPersona = :personId
    ');
    $q->execute(['personId' => $person]);
    $res = $q->fetchAll();

    foreach($res as $row)
        echo $row['titolo'] . '<br>';

?>