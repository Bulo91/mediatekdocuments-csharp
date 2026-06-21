#!/bin/sh

DATE=`date -I`
SAVE_DIR="/srv/disk13/4748356/www/mediatekdocuments.myartsonline.com/savebdd"

mysqldump -h fdb1033.awardspace.net -u 4748356_mediatek86 -pMediatek2026API --databases 4748356_mediatek86 --single-transaction --no-tablespaces | gzip > ${SAVE_DIR}/bddbackup_${DATE}.sql.gz
