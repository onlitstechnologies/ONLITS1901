#!/bin/bash
echo "fetching...\n"
mess=$(date +'%Y%m%d')
git pull https://onlitstechnologies@github.com/onlitstechnologies/ONLITS1901.git
echo "\npushing...\n"
git add .
git commit -m "$mess"
git push https://onlitstechnologies@github.com/onlitstechnologies/ONLITS1901.git
