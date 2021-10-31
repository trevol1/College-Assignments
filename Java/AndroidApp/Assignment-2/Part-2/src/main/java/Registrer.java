package com.example.trevoledrick.oblig2oppgave2;

import android.annotation.TargetApi;
import android.content.Intent;
import android.os.Build;
import android.support.annotation.RequiresApi;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;
import android.widget.Toolbar;

public class Registrer extends AppCompatActivity {

    @TargetApi(Build.VERSION_CODES.LOLLIPOP)
    @RequiresApi(api = Build.VERSION_CODES.LOLLIPOP)
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registrer);

    }

    private void setSupportActionBar(Toolbar myToolbar) {

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        if(item.getItemId()==R.id.action_Settings){
            Toast.makeText(this,"You have come to settings", Toast.LENGTH_SHORT).show();
        }
        if(item.getItemId()==R.id.action_favourite){
            Toast.makeText(this,"Your FAVOURITES", Toast.LENGTH_SHORT).show();
        }
        if(item.getItemId()==R.id.action_fun){
            Toast.makeText(this,"You are having fun", Toast.LENGTH_SHORT).show();
            startActivity(new Intent(this, childActivity.class));
        }
        if(item.getItemId()==R.id.action_message){
            Toast.makeText(this,"Type a message", Toast.LENGTH_SHORT).show();
        }
        return super.onOptionsItemSelected(item);
    }
}
