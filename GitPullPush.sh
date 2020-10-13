#!/bin/bash
mess=$(date +'%Y%m%d')
git pull https://github.com/onlitstechnologies/ONLITS1901.git
git add .
git commit -m "$mess"
git push https://github.com/onlitstechnologies/ONLITS1901.git
