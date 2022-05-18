<?php

    $db = new PDO('mysql:host=school.ncoltro.dev;dbname=5ci_ncoltro_2', 'ncoltro_php', 'dmLyOFbbfUgq5D3L');

    /*
    $name = 'rob';
    $q = "SELECT * FROM persone
          WHERE persone.cognome LIKE '$name%'
          OR persone.nome LIKE '$name%'";

    $res = $db->query($q);
    */

    $q = $db->prepare('SELECT * FROM persone WHERE persone.nome LIKE :name');
    $q->execute(['name' => '%rob%']);
    $res = $q->fetchAll();
    
    /* $rc = $res->rowCount();
    echo "Found $rc rows<br><br>"; */

    foreach($res as $row) {
        echo $row['cognome'] . ' ' . $row['nome'] . '<br>';
    }

?>