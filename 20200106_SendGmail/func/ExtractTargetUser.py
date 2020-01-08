#!/usr/bin/python
# -*- Coding: utf-8 -*-

import pandas as pd

class ExtractTargetUser():

    def create_target_user_df(self, attendance_df, mail_df):
        extract_df = attendance_df[attendance_df["warning_flg"] == 1]
        extract_df_2 = extract_df[["id", "full_name"]].drop_duplicates()
        return pd.merge(extract_df_2, mail_df, on=['id'])

if __name__ == "__main__":
    extractTargetUser = ExtractTargetUser()
