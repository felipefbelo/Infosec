#usar : ./ghdb.sh sitealvo.com.br
#!/bin/bash
SEARCH="firefox"
ALVO="$1"
echo "pesquisa no pastebin"
$SEARCH "https://google.com/search?q=site:pastebin.com+ALVO" 2> /dev/null
echo "pesquisa no trello"
$SEARCH "https://google.com/search?q=site:trello.com+ALVO" 2> /dev/null
echo "pesquisa por arquivos"
$SEARCH "https://google.com/search?q=site:$ALVO+ext:php+OR+ext:asp+OR+ext:txt" 2> /dev/null
