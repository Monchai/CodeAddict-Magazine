<?php
namespace CodeAddict;

    class ManageData{
        const PATH_DATA = 'data.php';

        //---------------------------------------------
        public function getPost(){
            
            $postdata = file_get_contents("php://input");
            $request = json_decode($postdata);   
            
            return $request;
        }
        //---------------------------------------------
        public function getAllData($forJSON=true){
            require(self::PATH_DATA);
            
            if($forJSON){
                return json_encode($data);        
            }else{
                return $data;
            }
            
        }
        //---------------------------------------------
        public function addData($code, $name){
            require(self::PATH_DATA);

            array_push($data, array(
                'code'  => $code,
                'name'  => $name
            ));

            $this->saveData($data);

        }
        //---------------------------------------------
        public function deleteData($code){
            require(self::PATH_DATA);
            
            $result = $this->searchData($data, $code, true);

            if($result){
                $this->saveData($data);

                return true;
            }else{
                return false;
            }
        }
        //---------------------------------------------
        public function editData($code, $name){
            require(self::PATH_DATA);
            
            $targetData = $this->searchData($data, $code);
            
            if($targetData!=null){
                $targetData['name'] = $name;
                $this->saveData($data);
            }
            
        }
        //---------------------------------------------
        public function filterData($code){
            require(self::PATH_DATA);
            
            return $this->searchData($data, $code);
        }
        //---------------------------------------------
        private function searchData(&$source, $code, $forDelete=false){
            $result = null;
 
            $lengthOfSource = count($source);
            
            for($i=0; $i<$lengthOfSource; $i++){
                
                $each = $source[$i];
                if($code==$each['code']){
                    if($forDelete==true){
                        unset($source[$i]);                        
                        $result=true;
                    }else{
                        $result = $each;    
                    }
                    
                    break;
                }
            }

            return $result;
        }
        //---------------------------------------------
        private function saveData($allData){

            $enter = "\n";
            $tab = "\t";
            
            $f = fopen(self::PATH_DATA, 'w');
            //------------------------------------------------------
            fwrite($f, '<?php'.$enter);
            fwrite($f, $enter.$tab.'$data = array(');

            foreach($allData as $each){
                fwrite($f, $enter.$tab.$tab.'array(');
                fwrite($f, $enter.$tab.$tab.$tab.'\'code\' => \''.$each['code'].'\',');
                fwrite($f, $enter.$tab.$tab.$tab.'\'name\' => \''.$each['name'].'\'');
                fwrite($f, $enter.$tab.$tab.'), ');
            }

            fwrite($f, $enter.$tab.');');
            fwrite($f, $enter.'?>');
            //------------------------------------------------------
            fclose($f);        
        }
    }
    //---------------------------------------------
?>