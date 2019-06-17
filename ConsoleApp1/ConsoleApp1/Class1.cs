﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {


        DROP PROCEDURE SPLIB.SELECTCLASSNETIDSBYTERM;
  
CREATE PROCEDURE SPLIB.SELECTCLASSNETIDSBYTERM(
               IN @CLASSID NUMERIC(5, 0) ,
                             IN @TERMYR NUMERIC(2,0),
                             IN @TERMMO NUMERIC(2,0))
                DYNAMIC RESULT SETS 1 
                LANGUAGE SQL
                SPECIFIC SPLIB.SELECTCLASSNETIDSBYTERM
                NOT DETERMINISTIC
                MODIFIES SQL DATA
                CALLED ON NULL INPUT
                BEGIN


                DECLARE C1 CURSOR WITH RETURN FOR
                SELECT C.USERUN AS NETID, D.USERUN AS EMAIL, E.NFMLMS AS NAME
                FROM
                   (SELECT IDNOCR, COUNT(*) AS ADDCOUNT FROM SRLIB.RGLIDCH
                    WHERE  CLCDCR = @CLASSID AND TRMMCR = @TERMMO AND TRMYCR = @TERMYR AND TRMCCR = 20  AND TYPECR = 'A' GROUP BY IDNOCR) A
                   LEFT JOIN
                   (SELECT IDNOCR, COUNT(*) AS DROPCOUNT FROM SRLIB.RGLIDCH
                   WHERE CLCDCR = @CLASSID AND TRMMCR = @TERMMO AND TRMYCR = @TERMYR AND TRMCCR = 20  AND TYPECR IN ('D','W') GROUP BY IDNOCR) B ON  A.IDNOCR = B.IDNOCR
               JOIN
                SRLIB.SRPUSER C ON A.IDNOCR = C.IDNOUN AND C.IDTYPE = 'US' JOIN
                SRLIB.SRPUSER D ON A.IDNOCR = D.IDNOUN AND D.IDTYPE = 'EM' JOIN
                SRLIB.SRPSRMS E ON E.IDNOMS = A.IDNOCR
                WHERE A.ADDCOUNT > B.DROPCOUNT OR B.DROPCOUNT IS NULL;


        OPEN C1;

        END  ; 
  
COMMENT ON SPECIFIC PROCEDURE SPLIB.SELECTCLASSNETIDSBYTERM
                IS 'Select NetId, Email and Name for a Class Id and term' ;

        GRANT EXECUTE ON PROCEDURE SPLIB.SELECTCLASSNETIDSBYTERM TO  CSLINUX;
GRANT EXECUTE ON PROCEDURE SPLIB.SELECTCLASSNETIDSBYTERM TO  WEBSTUD;



    }
}
