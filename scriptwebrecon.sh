#!/bin/bash
for palavra in $(cat wordlistsites.txt)
do
resposta=$(curl -s -H "User-agent: BeloTool" -o /dev/null -w "%{http_code}" $1/$palavra/)
if [ $resposta == "200" ]
then 
echo "Diretorio encontrado: $palavra"
fi
done
