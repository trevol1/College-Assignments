package no.trevolhiof.myapplication;

import android.app.Activity;
import android.os.Bundle;
import android.view.MenuItem;
import android.widget.TextView;

public class AnotherActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_another);
        this.getActionBar().setDisplayHomeAsUpEnabled(true);

    }

    //@Override
    //public boolean onOptionsItemSelected(MenuItem item){

       // if(item.getItemId() == android.R.id.home){
          //  finish();
      //  }

      //  return super.onOptionsItemSelected(item);

   // }



}
