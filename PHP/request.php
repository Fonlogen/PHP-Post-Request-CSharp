<?php
    $examplestring = $_POST['examplestring'];

    $host = "localhost";
    $user = "root";
    $pass = "";
    $name = "example"; // DB name here

    $db_connection = mysqli_connect($host, $user, $pass, $name);

    $query_string = "SELECT examplestring2 FROM exampletable WHERE examplestring = '{$examplestring}'";
    $query_result = $db_connection->query($query_string);

    if ($query_result->num_rows > 0) {
        while($row = mysqli_fetch_assoc($query_result))
            echo $row["examplestring2"];
    } else 
    {
        echo "No data"; // Return the No Data if no results were found
    }

    $db_connection->close();
?> 
