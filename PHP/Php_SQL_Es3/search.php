<table border=1>
    <tr>
        <th>Titolo</th>
        <th>Nome</th>
        <th>Cognome</th>
    </tr>
<?php

    if ($_REQUEST['fd'] == '') // Check input firstDate
        $fd = "SELECT MIN(dataProiezione) FROM proiezioni";
    else
        $fd = "'" . $_REQUEST['fd'] . "'";

    if ($_REQUEST['ld'] == '') // Check input lastDate
        $ld = "SELECT MAX(dataProiezione) FROM proiezioni";
    else
        $ld = "'" . $_REQUEST['ld'] . "'";
    
    // DB Con
    $db = new PDO('mysql:host=school.ncoltro.dev;dbname=5ci_ncoltro_2', 'ncoltro_php', 'dmLyOFbbfUgq5D3L');
    $db->exec("set names utf8");

    $q = $db->prepare("
        SELECT DISTINCT film.titolo, persone.nome, persone.cognome
        FROM proiezioni
        
        JOIN film ON film.id = proiezioni.idFilm
        JOIN attivita ON attivita.idFilm = film.id
        JOIN ruoli ON ruoli.id = attivita.idRuolo
        JOIN persone ON persone.id = attivita.idPersona
        JOIN sale ON sale.id = proiezioni.idSala
        JOIN citta ON citta.id = sale.idCittà
        
        WHERE 1 = 1
        AND citta.nomeCittà = 'Milano'
        AND proiezioni.dataProiezione >= ($fd)
        AND proiezioni.dataProiezione <= ($ld)
        AND ruoli.nomeRuolo = 'Regista'
    ");

    // Q exec
    $q->execute();
    $res = $q->fetchAll();

    // Output
    foreach($res as $row)
        echo '<tr><td>' . $row['titolo'] . '</td><td>' . $row['nome'] . '</td><td>' . $row['cognome'] . '</td></tr>';

?>