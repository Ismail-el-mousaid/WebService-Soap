<?php

$client = new SoapClient('http://localhost:8686/BanqueWS?wsdl');
$param = new stdClass();
$param -> montant=23;
$res = $client->__soapCall("ConversionEurotoDH",array($param));
echo($res->return);
$param2 = new stdClass();
$param2 -> code=2;
$res2 = $client->__soapCall("getCompte",array($param2));

echo("<br/>");
echo("Code=".$res2->return->code);
echo("<br/>Solde=".$res2->return->solde);

$res3=$client->__soapCall("listComptes",array());

echo ("<hr/>");
foreach($res3->return as $cpte){
    echo("Code=".$cpte->code);
    echo("<br/>Solde=".$cpte->solde);
    echo("<br/>");
}


?>