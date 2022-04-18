BEGIN_FUNCTION_MAP
.Feed, KOSDAQ시간외단일가호가잔량(DHA), DHA, attr, key=6, group=1;
    BEGIN_DATA_MAP
    InBlock,입력,input;
    begin
        단축코드,               shcode,            shcode,           char,  6;
    end
    OutBlock,출력,output;
    begin
시간외단일가호가시간,           dan_hotime,        dan_hotime,       char,  6;
시간외단일가장구분,             dan_hstatus,       dan_hstatus,      char,  2;
시간외단일가매도호가1,          dan_offerho1,      dan_offerho1,     long,  8;
시간외단일가매수호가1,          dan_bidho1,        dan_bidho1,       long,  8;
시간외단일가매도호가잔량1,      dan_offerrem1,     dan_offerrem1,    long,  12;
시간외단일가매수호가잔량1,      dan_bidrem1,       dan_bidrem1,      long,  12;
시간외단일가직전매도대비수량1,  dan_preoffercha1,  dan_preoffercha1, long,  12;
시간외단일가직전매수대비수량1,  dan_prebidcha1,    dan_prebidcha1,   long,  12;
시간외단일가매도호가2,          dan_offerho2,      dan_offerho2,     long,  8;
시간외단일가매수호가2,          dan_bidho2,        dan_bidho2,       long,  8;
시간외단일가매도호가잔량2,      dan_offerrem2,     dan_offerrem2,    long,  12;
시간외단일가매수호가잔량2,      dan_bidrem2,       dan_bidrem2,      long,  12;
시간외단일가직전매도대비수량2,  dan_preoffercha2,  dan_preoffercha2, long,  12;
시간외단일가직전매수대비수량2,  dan_prebidcha2,    dan_prebidcha2,   long,  12;
시간외단일가매도호가3,          dan_offerho3,      dan_offerho3,     long,  8;
시간외단일가매수호가3,          dan_bidho3,        dan_bidho3,       long,  8;
시간외단일가매도호가잔량3,      dan_offerrem3,     dan_offerrem3,    long,  12;
시간외단일가매수호가잔량3,      dan_bidrem3,       dan_bidrem3,      long,  12;
시간외단일가직전매도대비수량3,  dan_preoffercha3,  dan_preoffercha3, long,  12;
시간외단일가직전매수대비수량3,  dan_prebidcha3,    dan_prebidcha3,   long,  12;
시간외단일가매도호가4,          dan_offerho4,      dan_offerho4,     long,  8;
시간외단일가매수호가4,          dan_bidho4,        dan_bidho4,       long,  8;
시간외단일가매도호가잔량4,      dan_offerrem4,     dan_offerrem4,    long,  12;
시간외단일가매수호가잔량4,      dan_bidrem4,       dan_bidrem4,      long,  12;
시간외단일가직전매도대비수량4,  dan_preoffercha4,  dan_preoffercha4, long,  12;
시간외단일가직전매수대비수량4,  dan_prebidcha4,    dan_prebidcha4,   long,  12;
시간외단일가매도호가5,          dan_offerho5,      dan_offerho5,     long,  8;
시간외단일가매수호가5,          dan_bidho5,        dan_bidho5,       long,  8;
시간외단일가매도호가잔량5,      dan_offerrem5,     dan_offerrem5,    long,  12;
시간외단일가매수호가잔량5,      dan_bidrem5,       dan_bidrem5,      long,  12;
시간외단일가직전매도대비수량5,  dan_preoffercha5,  dan_preoffercha5, long,  12;
시간외단일가직전매수대비수량5,  dan_prebidcha5,    dan_prebidcha5,   long,  12;
시간외단일가총매도호가잔량,     dan_totofferrem,   dan_totofferrem,  long,  12;
시간외단일가총매수호가잔량,     dan_totbidrem,     dan_totbidrem,    long,  12;
시간외단일가직전매도호가총대비수량,dan_preoffercha,dan_preoffercha,  long,  12;
시간외단일가직전매수호가총대비수량,dan_prebidcha,  dan_prebidcha,    long,  12;
시간외단일가예상체결가격,       dan_yeprice,       dan_yeprice,      long,  8;
시간외단일가예상체결수량,       dan_yevolume,      dan_yevolume,     long,  12;
시간외단일가예상가직전가대비구분,dan_preysign,     dan_preysign,     char,  1;
시간외단일가예상가직전가대비,   dan_preychange,    dan_preychange,   long,  8;
시간외단일가예상가전일가대비구분,dan_jnilysign,    dan_jnilysign,    char,  1;
시간외단일가예상가전일가대비,   dan_jnilychange,   dan_jnilychange,  long,  8;
        단축코드,               shcode,            shcode,           char,  6;
		누적거래량,             volume,            volume,           long,  12;
    end
    END_DATA_MAP
END_FUNCTION_MAP
