<form action="films.php">
<select name="person">
<?php

    $search = $_REQUEST['search'];
    $db = new PDO('mysql:host=school.ncoltro.dev;dbname=5ci_ncoltro_2', 'ncoltro_php', 'dmLyOFbbfUgq5D3L');

    $q = $db->prepare('
        SELECT DISTINCT persone.id, persone.nome, persone.cognome
        FROM persone 
        JOIN attivita ON attivita.idPersona = persone.id
        WHERE attivita.idRuolo = 1
        AND (persone.nome LIKE :name
        OR persone.cognome LIKE :name)
    ');
    $q->execute(['name' => "%$search%"]);
    $res = $q->fetchAll();

    foreach($res as $row)
        echo '<option value="' . $row['id'] . '">' . $row['cognome'] . ' ' . $row['nome'] . '</option>';

?>
</select>
<button type="submit">Cerca film</button>
</form>